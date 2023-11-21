    /// <summary>
    /// Запрос ввода данных у пользователя
    /// </summary>
public static class Promt{
    /// <summary>
    /// Ввод данных пользователя, проверка введёных данных и запрос повторного ввода при неверных введённых данных
    /// </summary>
    /// <returns>Введённые значения для длины и высоты лабиринта</returns>
    private static int Print(){
        while(true){
            string? attemp = Console.ReadLine();
            bool isNumber = int.TryParse(attemp, out int answer);
            if (isNumber && answer>=5 && answer<=25) return answer;
            else if (!isNumber) {
                Console.WriteLine($"Введено не число.");
                Console.Write($"Попробуйте ещё раз: ");
            }
            else if (answer<5) {
                Console.WriteLine($"Введённый размер меньше минимального.");
                Console.Write($"Попробуйте ещё раз: ");
            }
            else {
                Console.WriteLine($"Введённый размер больше максимального.");
                Console.Write($"Попробуйте ещё раз: ");
            }
        }
    }
    /// <summary>
    /// Запрос на ввод вертикального или горизонтального размера лабиринта исходя из поступившего индекса
    /// </summary>
    /// <param name="index">Значение очерёдности ввода: 0 - вертикальный размер, 1 - горизонтальный размер</param>
    /// <returns>Введённые пользователем размеры лабиринта</returns>
    public static int Request(int index = 0){
        if (index == 0){
            Console.Write($"Введите вертикальный размер: ");
            return Print();
        } else {
            Console.Write($"Введите горизонтальный размер: ");
            return Print();
        }
    }
}