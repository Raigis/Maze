public static class Rooms{
    public static string Room(int numRoom, int index){
        string[] room = new string[4];
        switch(numRoom){
        case 1: 
            room[0] = " __   __ ";
            room[1] = "|__| |__|";
            room[2] = " __   __ ";
            room[3] = "|__| |__|";
            return room[index];
        case 2: 
            room[0] = " _______ ";
            room[1] = "|____   |";
            room[2] = " __  |  |";
            room[3] = "|__| |__|";
            return room[index];
        case 3: 
            room[0] = " __   __ ";
            room[1] = "|__| |  |";
            room[2] = " ____|  |";
            room[3] = "|_______|";
            return room[index];
        case 4: 
            room[0] = " __   __ ";
            room[1] = "|  | |__|";
            room[2] = "|  |____ ";
            room[3] = "|_______|";
            return room[index];
        case 5: 
            room[0] = " _______ ";
            room[1] = "|   ____|";
            room[2] = "|  |  __ ";
            room[3] = "|__| |__|";
            return room[index];
        case 6: 
            room[0] = " __   __ ";
            room[1] = "|__| |  |";
            room[2] = " __  |  |";
            room[3] = "|__| |__|";
            return room[index];
        case 7: 
            room[0] = " __   __ ";
            room[1] = "|__| |__|";
            room[2] = " _______ ";
            room[3] = "|_______|";
            return room[index];
        case 8: 
            room[0] = " __   __ ";
            room[1] = "|  | |__|";
            room[2] = "|  |  __ ";
            room[3] = "|__| |__|";
            return room[index];
        case 9: 
            room[0] = " _______ ";
            room[1] = "|_______|";
            room[2] = " __   __ ";
            room[3] = "|__| |__|";
            return room[index];
        case 10: 
            room[0] = " __   __ ";
            room[1] = "|  | |  |";
            room[2] = "|  | |  |";
            room[3] = "|__| |__|";
            return room[index];
        case 11: 
            room[0] = " _______ ";
            room[1] = "|_______|";
            room[2] = " _______ ";
            room[3] = "|_______|";
            return room[index];
        case 12: 
            room[0] = " _______ ";
            room[1] = "|____   |";
            room[2] = " ____|  |";
            room[3] = "|_______|";
            return room[index];
        case 13: 
            room[0] = " __   __ ";
            room[1] = "|  | |  |";
            room[2] = "|  |_|  |";
            room[3] = "|_______|";
            return room[index];
        case 14: 
            room[0] = " _______ ";
            room[1] = "|   ____|";
            room[2] = "|  |____ ";
            room[3] = "|_______|";
            return room[index];
        case 15: 
            room[0] = " _______ ";
            room[1] = "|   _   |";
            room[2] = "|  | |  |";
            room[3] = "|__| |__|";
            return room[index];
        case 16: 
            room[0] = " _______ ";
            room[1] = "|____   |";
            room[2] = " ____-> |";
            room[3] = "|_______|";
            return room[index];
        case 17: 
            room[0] = " __   __ ";
            room[1] = "|  |||  |";
            room[2] = "|  |v|  |";
            room[3] = "|_______|";
            return room[index];
        case 18: 
            room[0] = " _______ ";
            room[1] = "|   ____|";
            room[2] = "| <-____ ";
            room[3] = "|_______|";
            return room[index];
        case 19: 
            room[0] = " _______ ";
            room[1] = "|   ^   |";
            room[2] = "|  |||  |";
            room[3] = "|__| |__|";
            return room[index];
        case 20: 
            room[0] = " _______ ";
            room[1] = "|____   |";
            room[2] = " ____<- |";
            room[3] = "|_______|";
            return room[index];
        case 21: 
            room[0] = " __   __ ";
            room[1] = "|  |^|  |";
            room[2] = "|  |||  |";
            room[3] = "|_______|";
            return room[index];
        case 22: 
            room[0] = " _______ ";
            room[1] = "|   ____|";
            room[2] = "| ->____ ";
            room[3] = "|_______|";
            return room[index];
        case 23: 
            room[0] = " _______ ";
            room[1] = "|   |   |";
            room[2] = "|  |v|  |";
            room[3] = "|__| |__|";
            return room[index];
        default: return "0";
        }        
    }
}