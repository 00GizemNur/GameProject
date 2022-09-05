using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager:IGameService
    {
         
        List<Game> games = new List<Game>();

        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine(game.GameName +"Başarılı Bir Şekilde Eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Silmek istenilen Oyun : " + game.GameName 
                + "Lütfen bekleyin. Siliniyor!");

            games.Remove(game);
            Console.WriteLine("Oyun Başarılı Bir Şekilde Silindi.");
        }

        public void List()
        {
            Console.WriteLine("---- Oyunlar ----");
            foreach (Game game in games)
            {
                Console.WriteLine("Oyunun Adı:" + game.GameName +
                    "Oyunun Kategorisi:" + game.GameCategory + "Oyunun Fiyatı:" + game.GamePrice);
            }
            Console.WriteLine("Oyunlar Başarılı Bir Şekilde Listelendi.");
        }

        public void Update(Game game)
        {
            Console.Write("Güncellemek istediğiniz oyunun Id'sini girin:");
            game.Id = Convert.ToInt32(Console.ReadLine());
            game.GameName = Console.ReadLine();
            game.GameCategory = Console.ReadLine();
            game.GamePrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Oyun Başarılı Bir Şekilde Güncellendi.");
        }
    }

}

