using static Generator;
// Печать карты лабиринта
//ВНИМАНИЕ! Сгенерированный лабиринт может быть не проходимым. Просьба сильно не обижаться и попробовать снова.
// Для того, чтобы увидеть карту из номеров комнат, замените MapPictureGenerating() на MapNumRoomsGenerating
Console.Clear();
string[,] map = MapPictureGenerating();
for (int i = 0; i<map.GetLength(0); i++){
    for(int j = 0; j<map.GetLength(1)-1; j++){
        Console.Write($"{map[i,j]}");
    }
    Console.WriteLine($"{map[i,map.GetLength(1)-1]}");
}