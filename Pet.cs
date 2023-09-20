public class Pet
{
    private int _currentPetCount;
    private string _species = string.Empty;
    private string _id = string.Empty;
    private string _age = string.Empty;
    private string _physicalDescription = string.Empty;
    private string _personalityDescription = string.Empty;
    private string _nickname = string.Empty;

    public string Species { get => $"Species: {_species}"; }
    public string Id { get => $"ID #: {_id}"; }
    public string Age { get => $"Age: {_age}"; }
    public string PhysicalDescription { get => $"Physical description: {_physicalDescription}"; }
    public string PersonalityDescription { get => $"Personality description: {_personalityDescription}"; }
    public string Nickname { get => $"Nickname: {_nickname}"; }

    public Pet(int currentPetCount)
    {
        _currentPetCount = currentPetCount;
        GetSpecies();
        GenerateId();
        GetAge();
        GetPhysicalDescription();
        GetPersonalityDescription();
        GetNickname();
    }

    private void GetSpecies()
    {
        bool validEntry = false;
        string? readResult = string.Empty;

        do
        {
            Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");

            readResult = Console.ReadLine();

            if (readResult != null)
            {

                _species = readResult.ToLower();
                if (readResult != "dog" && readResult != "cat")
                    validEntry = false;
                else
                    validEntry = true;

            }

        } while (!validEntry);
    }

    private void GenerateId()
    {
        _id = _species.Substring(0, 1) + (_currentPetCount + 1).ToString();
    }

    private void GetAge()
    {
        bool validEntry = false;

        do
        {
            int petAge;

            Console.WriteLine("Enter the pet's age or enter ? if unknown");

            string? readResult = Console.ReadLine();

            if (readResult != null)
            {
                _age = readResult;
                
                if (readResult != "?")
                    validEntry = int.TryParse(readResult, out petAge);
                else
                    validEntry = true;
            }

        } while (!validEntry);
    }

    private void GetPhysicalDescription()
    {
        do
        {
            Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");

            string? readResult = Console.ReadLine();

            if (readResult != null)
            {
                _physicalDescription = readResult.ToLower();
                if (readResult == "")
                {
                    _physicalDescription = "tbd";
                }
            }

        } while (_physicalDescription == "");
    }

    private void GetPersonalityDescription()
    {
        do
        {
            Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");

            string? readResult = Console.ReadLine();

            if (readResult != null)
            {
                _personalityDescription = readResult.ToLower();
                if (readResult == "")
                {
                    _personalityDescription = "tbd";
                }
            }
        } while (_personalityDescription == "");
    }

    private void GetNickname()
    {
        do
        {
            Console.WriteLine("Enter a nickname for the pet");
            string? readResult = Console.ReadLine();
            if (readResult != null)
            {
                _nickname = readResult.ToLower();
                if (readResult == "")
                {
                    _nickname = "tbd";
                }
            }
        } while (_nickname == "");
    }
}