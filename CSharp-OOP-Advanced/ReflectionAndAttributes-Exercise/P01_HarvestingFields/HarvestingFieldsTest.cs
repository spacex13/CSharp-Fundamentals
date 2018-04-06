namespace P01_HarvestingFields
{
    using System;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            string command;

            HarvestingFields hf = new HarvestingFields();

            while ((command = Console.ReadLine()) != "HARVEST")
            {
                var modifier = command;

                hf.Harvest(modifier);
            }
        }
    }
}