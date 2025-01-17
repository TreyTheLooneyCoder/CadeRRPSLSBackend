namespace CadeRRPSLSProject.Services
{
    public class RPSLSServices
    {
        public string lizardSpock()
        {
            Random rng = new Random();
            int comChoiceNum = rng.Next(6);
            
            switch(comChoiceNum)
            {
                case 1: 
                    return "Rock";
                   
                case 2: 
                    return "Paper";
                
                case 3: 
                    return "Scissors";

                case 4: 
                    return "Lizard";

                default: 
                    return "Spock";
                
            }
        }
    }
}