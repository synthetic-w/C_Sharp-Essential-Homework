/*
Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3
метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop()
соответственно.
Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
Написать программу, которая выполняет проигрывание и запись.
*/

using _02_IPlayIRecord.Models;

Console.WriteLine("Программа записи и воспроизведения\n" +
                  "Для воспроизведения нажмите 1\n" +
                  "Для паузы нажмите 2\n" +
                  "Для записи нажмите 3\n" +
                  "Для остановки нажмите 4\n" +
                  "Для выхода из программы нажмите 0");
Input:
string input = Console.ReadLine();

Player player = new Player();

switch (input)
{
    case "0":
        Console.WriteLine("Выход из программы");
        break;

    case "1":
        player.Play();
        goto Input;

    case "2":
        player.Pause();
        goto Input;

    case "3":
        player.Record();
        goto Input;

    case "4":
        player.Stop();
        goto Input;
}
