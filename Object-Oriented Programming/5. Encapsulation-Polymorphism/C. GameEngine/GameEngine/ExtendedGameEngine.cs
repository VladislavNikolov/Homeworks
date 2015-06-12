namespace TheSlum.GameEngine
{
    using System;
    using Characters;
    using Items;

    public class ExtendedGameEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.Additem(inputParams);
                    break;
                default:
                    base.ExecuteCommand(inputParams);
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            Character newChar;
            switch (inputParams[1])
            {
                case "warrior":
                    newChar = new Warrior(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        (Team)Enum.Parse(typeof(Team), inputParams[5]));
                    this.characterList.Add(newChar);
                    break;
                case "mage":
                    newChar = new Mage(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        (Team)Enum.Parse(typeof(Team), inputParams[5]));
                    this.characterList.Add(newChar);
                    break;
                case "healer":
                    newChar = new Healer(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        (Team)Enum.Parse(typeof(Team), inputParams[5]));
                    this.characterList.Add(newChar);
                    break;
            }
        }

        protected void Additem(string[] inputParams)
        {
            Character charToGetItem = GetCharacterById(inputParams[1]);
            Item newItem;

            switch (inputParams[2])
            {
                case "axe":
                    newItem = new Axe(inputParams[3]);
                    charToGetItem.AddToInventory(newItem);
                    break;
                case "shield":
                    newItem = new Shield(inputParams[3]);
                    charToGetItem.AddToInventory(newItem);
                    break;
                case "injection":
                    newItem = new Injection(inputParams[3]);
                    charToGetItem.AddToInventory(newItem);
                    break;
                case "pill":
                    newItem = new Pill(inputParams[3]);
                    charToGetItem.AddToInventory(newItem);
                    break;
            }
        }
    }
}
