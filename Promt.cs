public static class Promt{
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
    public static int Request(int index = 0){
        if (index == 0){
            Console.Write($"Введите высоту: ");
            return Print();
        } else {
            Console.Write($"Введите длину: ");
            return Print();
        }
    }
}