namespace Infestation
{
    using System;

    using Infestation.Units;
    using Infestation.Supplements;

    public class ExtendedHoldingPen : HoldingPen
    {
        protected override void ExecuteProceedSingleIterationCommand()
        {
            base.ExecuteProceedSingleIterationCommand();
        }

        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            switch (interaction.InteractionType)
            {
                case InteractionType.Infest:
                    Unit targetUnit = this.GetUnit(interaction.TargetUnit);

                    //bool areBiological = targetUnit.UnitClassification == UnitClassification.Biological && interaction.SourceUnit.UnitClassification == UnitClassification.Biological,

                    //    isMechanical = targetUnit.UnitClassification == UnitClassification.Mechanical && interaction.SourceUnit.UnitClassification == UnitClassification.Psionic,

                    //    arePsionic = targetUnit.UnitClassification == UnitClassification.Psionic && interaction.SourceUnit.UnitClassification == UnitClassification.Psionic;

                    //if (areBiological || isMechanical || arePsionic)
                    //{
                    targetUnit.AddSupplement(new InfestationSpores());
                    //}
                    break;
                default:
                    base.ProcessSingleInteraction(interaction);
                    break;
            }
        }

        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            // o	Syntax: supplement SupplementType targetUnitId
            ISupplement supplement;
            switch (commandWords[1])
            {
                case "PowerCatalyst":
                    supplement = new PowerCatalyst();
                    break;
                case "AggressionCatalyst":
                    supplement = new AggressionCatalyst();
                    break;
                case "HealthCatalyst":
                    supplement = new HealthCatalyst();
                    break;
                case "Weapon":
                    supplement = new Weapon();
                    break;
                default:
                    throw new NotSupportedException("There are no supplements of this type.");
            }

            var currentUnit = GetUnit(commandWords[2]);
            if (currentUnit != null)
            {
                currentUnit.AddSupplement(supplement);
            }
        }

        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            Unit currentUnit = null;
            switch (commandWords[1])
            {
                case "Tank":
                    currentUnit = new Tank(commandWords[2]);
                    break;
                case "Marine":
                    currentUnit = new Marine(commandWords[2]);
                    break;
                case "Parasite":
                    currentUnit = new Parasite(commandWords[2]);
                    break;
                case "Queen":
                    currentUnit = new Queen(commandWords[2]);
                    break;
                default:
                    base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }
            if (currentUnit != null)
            {
                base.InsertUnit(currentUnit);
            }
        }
    }
}