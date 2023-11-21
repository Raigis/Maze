using static Rooms;
using static Promt;
public static class Generator{
    private static int[] ArrayAppend (int[] array, int temp){
        int[] result = new int[array.Length+1];
        array.CopyTo(result, 0);
        result[array.Length] = temp;
        return result;
    }
    private static int[] VarY(int y){
        if(y == 1 || y == 6 || y == 8 || y == 9){
            int[] poss = {1,3,4,6,7,8,10,13,17,21};
            return poss;
        } else if(y == 2 || y == 5 || y == 10 || y == 15 || y == 19 || y == 23){
            int[] poss = {1,3,4,6,7,8,10};
            return poss;
        } else {
            int[] poss = {2,5,9,11,12,14,15,16,18,19,20,22,23};
            return poss;
        }
    }
    private static int[] VarX(int x){
        if(x == 1 || x == 7 || x == 8 || x == 9){
            int[] poss = {1,2,3,6,7,9,11,12,16,20};
            return poss;
        } else if(x == 4 || x == 5 || x == 11 || x == 14 || x == 18 || x == 22){
            int[] poss = {1,2,3,6,7,9,11,16,20};
            return poss;
        } else {
            int[] poss = {4,5,8,10,13,14,15,17,18,19,21,22,23};
            return poss;
        }
    }
    private static int[] ComparisonPossibilites(int[] possCell, int[]? possX = null, int[]? possY = null){
        int[] possibles = new int[1];
        if(possY == null){
            for (int i = 0; i < possX.Length; i++){
                for (int j = 0; j < possCell.Length; j++){
                    if (possX[i] == possCell[j]) {
                        if (possibles[0] == 0) possibles[0] = possCell[j];
                        possibles = ArrayAppend(possibles, possCell[j]);
                    }
                }
            }
        } else if(possX == null){
            for (int i = 0; i < possY.Length; i++){
                for (int j = 0; j < possCell.Length; j++){
                    if (possY[i] == possCell[j]) {
                        if (possibles[0] == 0) possibles[0] = possCell[j];
                        possibles = ArrayAppend(possibles, possCell[j]);
                    }
                }
            }
        } else {
            for(int i = 0; i < possX.Length; i++){
                for(int j = 0; j < possY.Length; j++){
                    for(int k = 0; k < possCell.Length; k++){
                        if (possCell[k] == possX[i] && possCell[k]==possY[j]) {
                            if (possibles[0] == 0) possibles[0] = possCell[k];
                            possibles = ArrayAppend(possibles, possCell[k]);
                        }
                    }
                }
            }
        }
        return possibles;
    }
    private static int RightLowerCorner(int x ,int y, bool exit){
        int cell;
        if ((x == 4 || x == 7 || x == 11 || x == 14 || x == 18 || x == 22) && (y == 2 || y == 6 || y == 10 || y == 15 || y == 19 || y == 24)) cell = 3;
        else if (x == 4 || x == 7 || x == 11 || x == 14 || x == 18 || x == 22){
            if(!exit) cell = 16;
            else cell = 12;
        }
        else if (y == 2 || y == 6 || y == 10 || y == 15 || y == 19 || y == 24){
            if(!exit) cell = 17;
            else cell = 13;
        }
        else cell = 0;
        return cell;
    }
    private static int LowerEdge(bool enter, bool exit, int x ,int y){
        int cell;
        if (!enter && !exit){
            int[] possCell = {3,4,7,11,12,13,14,16,17,18,20,21,22};
            int[] possibles = ComparisonPossibilites(possCell, possX: VarX(x), possY: VarY(y));
            cell = possibles[new Random().Next(0, possibles.Length)];
        } else if (!enter){
            int[] possCell = {3,4,7,11,12,13,14,20,21,22};
            int[] possibles = ComparisonPossibilites(possCell, possX: VarX(x), possY: VarY(y));
            cell = possibles[new Random().Next(0, possibles.Length)];
        } else if (!exit){
            int[] possCell = {3,4,7,11,12,13,14,16,17,18};
            int[] possibles = ComparisonPossibilites(possCell, possX: VarX(x), possY: VarY(y));
            cell = possibles[new Random().Next(0, possibles.Length)];
        } else {
            int[] possCell = {3,4,7,11,12,13,14};
            int[] possibles = ComparisonPossibilites(possCell, possX: VarX(x), possY: VarY(y));
            cell = possibles[new Random().Next(0, possibles.Length)];
        }
        return cell;
    }
    private static int LeftLowerCorner(bool enter, bool exit, int y){
        int cell;
        if (!enter && !exit){
            int[] possCell = {4,13,14,17,18,21,22};
            int[] possibles = ComparisonPossibilites(possCell, possY: VarY(y));
            cell = possibles[new Random().Next(0, possibles.Length)];
        } else if (!enter){
            int[] possCell = {4,13,14,21,22};
            int[] possibles = ComparisonPossibilites(possCell, possY: VarY(y));
            cell = possibles[new Random().Next(0, possibles.Length)];
        } else if (!exit){
            int[] possCell = {4,13,14,17,18};
            int[] possibles = ComparisonPossibilites(possCell, possY: VarY(y));
            cell = possibles[new Random().Next(0, possibles.Length)];
        } else {
            int[] possCell = {4,13,14};
            int[] possibles = ComparisonPossibilites(possCell, possY: VarY(y));
            cell = possibles[new Random().Next(0, possibles.Length)];
        }
        return cell;
    }
    private static int RightEdge(bool enter, bool exit, int x ,int y){
        int cell;
        if (!enter && !exit){
            int[] possCell = {2,3,6,10,12,13,15,16,17,19,20,21,23};
            int[] possibles = ComparisonPossibilites(possCell, possX: VarX(x), possY: VarY(y));
            cell = possibles[new Random().Next(0, possibles.Length)];
        } else if (!enter){
            int[] possCell = {2,3,6,10,12,13,15,20,21,23};
            int[] possibles = ComparisonPossibilites(possCell, possX: VarX(x), possY: VarY(y));
            cell = possibles[new Random().Next(0, possibles.Length)];
        } else if (!exit){
            int[] possCell = {2,3,6,10,12,13,15,16,17,19};
            int[] possibles = ComparisonPossibilites(possCell, possX: VarX(x), possY: VarY(y));
            cell = possibles[new Random().Next(0, possibles.Length)];
        } else {
            int[] possCell = {2,3,6,10,12,13,15};
            int[] possibles = ComparisonPossibilites(possCell, possX: VarX(x), possY: VarY(y));
            cell = possibles[new Random().Next(0, possibles.Length)];
        }
        return cell;
    }
    private static int Centre(bool enter, bool exit, int x, int y){
        int cell;
        int[] possX = VarX(x);
        int[] possY = VarY(y);
        int[] possCell = {1,2,3,4,5,6,7,8,9,10,11};
        int[] possibles = ComparisonPossibilites(possCell, possX: VarX(x), possY: VarY(y));
        cell = possibles[new Random().Next(0, possibles.Length)];
        return cell;
    }
    private static int LeftEdge(bool enter, bool exit, int y){
        int cell;
        int[] possY = VarY(y);
        if (!enter && !exit){
            int[] possCell = {4,5,8,10,13,14,15,17,18,19,21,22,23};
            int[] possibles = ComparisonPossibilites(possCell, possY: VarY(y));
            cell = possibles[new Random().Next(0, possibles.Length)];
        } else if (!enter){
            int[] possCell = {4,5,8,10,13,14,15,21,22,23};
            int[] possibles = ComparisonPossibilites(possCell, possY: VarY(y));
            cell = possibles[new Random().Next(0, possibles.Length)];
        } else if (!exit){
            int[] possCell = {4,5,8,10,13,14,15,17,18,19};
            int[] possibles = ComparisonPossibilites(possCell, possY: VarY(y));
            cell = possibles[new Random().Next(0, possibles.Length)];
        } else {
            int[] possCell = {4,5,8,10,13,14,15};
            int[] possibles = ComparisonPossibilites(possCell, possY: VarY(y));
            cell = possibles[new Random().Next(0, possibles.Length)];
        }
        return cell;
    }
    private static int RightUpperCorner(bool enter, int x){
        int cell;
        if (!enter){
            int[] possCell = {2,12,15,20,23};
            int[] possibles = ComparisonPossibilites(possCell, possX: VarX(x));
            cell = possibles[new Random().Next(0, possibles.Length)];
        } else {
            int[] possCell = {2,12,15};
            int[] possibles = ComparisonPossibilites(possCell, possX: VarX(x));
            cell = possibles[new Random().Next(0, possibles.Length)];
        }
        return cell;
    }
    private static int UpperEdge(bool enter, int x){
        int cell;
        if (!enter){
            int[] possCell = {2,5,9,11,12,14,15,20,22,23};
            int[] possibles =ComparisonPossibilites(possCell, possX: VarX(x));
            cell = possibles[new Random().Next(0, possibles.Length)];
        } else {
            int[] possCell = {2,5,9,11,12,14,15};
            int[] possibles = ComparisonPossibilites(possCell, possX: VarX(x));
            cell = possibles[new Random().Next(0, possibles.Length)];
        }
        return cell;
    }
    private static int LeftUpperCorner(bool enter){
        int cell;
        if (!enter){
            int[] possibles = {5,22,23};
            cell = possibles[new Random().Next(0, possibles.Length)];
        } else {
            int[] possibles = {5,14,15};
            cell = possibles[new Random().Next(0, possibles.Length)];
        }
        return cell;
    }
    public static int[,] MapCoordinatesGenerating(){
        Console.WriteLine($"Введите размеры лабиринта.\nМинимальный размер: 5х5.\nМаксимальный размер: 25х25.");
        bool isEnter = false;
        bool isExit = false;
        int[,] map = new int[Request(),Request(1)];
        for(int i = 0; i < map.GetLength(0); i++ ){
            for(int j = 0; j < map.GetLength(1); j++){
                if (i == 0 && j == 0) map[i,j] = LeftUpperCorner(isEnter);
                else if (i == 0 && j != map.GetLength(1)-1) map[i,j] = UpperEdge(isEnter, map[i, j-1]);
                else if (i == 0 && j == map.GetLength(1)-1) map[i,j] = RightUpperCorner(isEnter, map[i, j-1]);
                else if (i != map.GetLength(0)-1 && j == 0) map[i,j] = LeftEdge(isEnter, isExit, map[i-1,j]);
                else if (i != map.GetLength(0)-1 && j != map.GetLength(1)-1) map[i,j] = Centre(isEnter, isExit, map[i, j-1], map[i-1,j]);
                else if (i != map.GetLength(0)-1 && j == map.GetLength(1)-1) map[i,j] = RightEdge(isEnter, isExit, map[i, j-1], map[i-1,j]);
                else if (i == map.GetLength(0)-1 && j == 0) map[i,j] = LeftLowerCorner(isEnter, isExit, map[i-1,j]);
                else if (i == map.GetLength(0)-1 && j != map.GetLength(1)-1) map[i,j] = LowerEdge(isEnter, isExit, map[i, j-1], map[i-1,j]);
                else map[i,j] = RightLowerCorner(map[i, j-1], map[i-1,j], isExit);
                if(map [i,j] == 16 || map [i,j] == 17 || map [i,j] == 18 || map [i,j] == 19) isExit = true;
                if(map [i,j] == 20 || map [i,j] == 21 || map [i,j] == 22 || map [i,j] == 23) isEnter = true;
            }
        }
        return map;
    }

    public static string[,] MapPictureGenerating(){
        int[,] mapCoor = MapCoordinatesGenerating();
        string[,] mapPic = new string[mapCoor.GetLength(0)*3+1, mapCoor.GetLength(1)];
        for (int i = 0; i < mapPic.GetLength(0); i+=3){
            for(int j = 0; j < mapPic.GetLength(1); j++){
                if(i == 0){
                    for(int k = 0; k < 4; k++){
                        mapPic[k, j] = Room(mapCoor[i,j], k);
                    }
                } else {
                    for(int k = 0; k < 3; k++){
                        mapPic[k+i, j] = Room(mapCoor[(i-1)/3,j], k+1);
                    }
                }
                if(i == 0 && j == mapPic.GetLength(1)-1) i++;
            }
        }
        return mapPic;
    }
}