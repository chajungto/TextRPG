using System.Reflection.Metadata;

namespace TextRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //커서 안보이게 설정
            Console.CursorVisible = false;

            TextRPGGame game = new TextRPGGame();
            game.InitialEquipment();
            game.InitialItem();
            game.Run();
        }
    }
}
