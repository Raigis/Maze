using static Generator;
Console.Clear();
string[,] mapPic = MapPictureGenerating();
for (int i = 0; i<mapPic.GetLength(0); i++){
    for(int j = 0; j<mapPic.GetLength(1)-1; j++){
        Console.Write($"{mapPic[i,j]}");
    }
    Console.WriteLine($"{mapPic[i,mapPic.GetLength(1)-1]}");
}