namespace Data_Structures_and_Algorithms.LearnDSAlgorithms.ADT;

public class Pokemon
{
    //Representation of data
    public string Name { get; set; }
    public int Exp { get; set; }

    //Is an abstract Data Type
    //Representation of the Operation
    public bool IsPokemon()
    {
        return true;
    }
}