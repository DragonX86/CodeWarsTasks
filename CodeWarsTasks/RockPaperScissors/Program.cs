string Rps(string first, string last)
{
    if (first == last)
        return "Draw!";
    
    string result = "";
    
    switch (first) {
        case "rock":
            if (last == "scissors")
                result = "Player 1 won!";
            if (last == "paper")
                result = "Player 2 won!";
            break;
        case "paper":
            if (last == "rock")
                result = "Player 1 won!";
            if (last == "scissors")
                result = "Player 2 won!";
            break;
        case "scissors":
            if (last == "paper")
                result = "Player 1 won!";
            if (last == "rock")
                result = "Player 2 won!";
            break;
    }

    return result;
}