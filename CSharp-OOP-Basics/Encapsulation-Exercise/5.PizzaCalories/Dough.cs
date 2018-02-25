public class Dough
{
    private string flourType;

    public string FlourType
    {
        get { return flourType; }
        set
        {
            switch (value)
            {
                case "White":
            }
            flourType = value;
        }
    }

    private string bakingTechnique;

    public string BakingTechnique
    {
        get { return bakingTechnique; }
        set { bakingTechnique = value; }
    }

    private double weight;

    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public double CaloriesPerGram(int grams)
    {
        //return 2 * grams * (double)flourType *  
    }

}