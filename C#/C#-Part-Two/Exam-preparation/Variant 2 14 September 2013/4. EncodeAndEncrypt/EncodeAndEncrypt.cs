using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Constraints
•	All symbols in the message will be capital English letters
•	Тhe message and the cypher will be no more than 1500 symbols each
•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.
*/

class EncodeAndEncrypt
{
    static string message;
    static string cypher;
    static string readyToBeEncode;

    static void ReadInput()
    {
        message = Console.ReadLine();
        cypher = Console.ReadLine();
    }

    static void Encrypt()
    {
        var encoded = new StringBuilder();
        if (message.Length >= cypher.Length)
        {
            var j = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (i >= cypher.Length)
                {
                    j = i % cypher.Length;
                }

                encoded.Append((char)(((message[i] - 'A') ^ (cypher[j] - 'A')) + 'A'));

                if (i < cypher.Length)
                {
                    j++;
                }
            }
        }
        else
        {
            encoded.Append(message);

            var j = 0;
            for (int i = 0; i < cypher.Length; i++)
            {
                if (i >= encoded.Length)
                {
                    j = i % encoded.Length;
                    encoded[j] = ((char)(((encoded[j] - 'A') ^ (cypher[i] - 'A')) + 'A'));
                }
                else
                {
                    encoded[j] = ((char)(((encoded[j] - 'A') ^ (cypher[i] - 'A')) + 'A'));
                }

                if (i < cypher.Length)
                {
                    //encoded.Append((char)(((message[i] - 'A') ^ (cypher[j] - 'A')) + 'A'));
                    j++;
                }
            }
        }

        readyToBeEncode = encoded.ToString();
    }

    static string Encode(string value)
    {
        var encoded = new StringBuilder(value.Length);
        var length = value.Length;
        var runTimeSeq = string.Empty;
        var currentCounter = 1;
        var index = 0;

        while (index < value.Length)
        {
            var currentChar = value[index];

            if (index + 1 < value.Length)
            {
                while (currentChar == value[index + 1])
                {
                    currentCounter++;
                    index++;

                    if (index + 1 >= value.Length)
                    {
                        break;
                    }
                }
            }

            runTimeSeq = currentCounter.ToString() + currentChar;
            if (currentCounter > runTimeSeq.Length)
            {
                encoded.Append(runTimeSeq);
            }
            else if (currentCounter == runTimeSeq.Length)
            {
                encoded.Append(new string(currentChar, currentCounter));
            }
            else
            {
                encoded.Append(currentChar);
            }

            currentCounter = 1;
            index++;
        }

        return encoded.ToString();
    }

    /*static string Encode(string value)
    {
        var encoded = new StringBuilder();
        var length = value.Length;
        var runTimeSeq = string.Empty;
        var currentCounter = 1;

        for (int i = 0, j = 1; j < length; i++, j++)
        {
            if (value[j] == value[i])
            {
                currentCounter++;
                if (j == length - 1)
                {
                    if (value[j] == value[i])
                    {
                        runTimeSeq = currentCounter.ToString() + value[i];
                        if (currentCounter > runTimeSeq.Length)
                        {
                            encoded.Append(runTimeSeq);
                        }
                        else
                        {
                            runTimeSeq = value[i].ToString() + value[j];
                            encoded.Append(runTimeSeq);
                        }
                    }

                }
                else
                {
                    continue;
                }
            }
            else
            {
                runTimeSeq = currentCounter.ToString() + value[i];
                if (currentCounter > runTimeSeq.Length)
                {
                    encoded.Append(runTimeSeq);
                }
                else
                {
                    if (j == length - 1)
                    {
                        runTimeSeq = currentCounter.ToString() + value[i];
                        if (currentCounter > runTimeSeq.Length)
                        {
                            encoded.Append(runTimeSeq);
                        }
                        else
                        {
                            runTimeSeq = value[i].ToString() + value[j];
                            encoded.Append(runTimeSeq);
                        }
                    }
                    else
                    {
                        if (currentCounter == 2)
                        {
                            runTimeSeq = value[i - 1].ToString() + value[j - 1];
                            encoded.Append(runTimeSeq);
                        }
                        else
                        {
                            encoded.Append(value[i]);
                        }
                    }
                }

                currentCounter = 1;
            }
        }

        return encoded.ToString();
    }*/

    static void Main()
    {
        //ABC
        //PQRST
        ReadInput();
        Encrypt();
        var result = Encode(readyToBeEncode + cypher) + cypher.Length.ToString();
        Console.WriteLine(result);
        //Console.WriteLine(result == @"BKOXHI\EQOGX[YSOFTWARE8");
    }
}
