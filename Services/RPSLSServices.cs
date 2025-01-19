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
                    return "rock";
                   
                case 2: 
                    return "paper";
                
                case 3: 
                    return "scissors";

                case 4: 
                    return "lizard";

                default: 
                    return "spock";
                
            }
        }
    }
}