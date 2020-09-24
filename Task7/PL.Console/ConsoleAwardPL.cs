using BLL.Interfaces;
using BLL.Dependencies;
using Entitiens;
using System;
using System.Collections.Generic;
using PL.Interfaces;

namespace Tasks7
{
    public class ConsoleAwardPL : IAwardPL
    {

        private IAwardBLL _bll;
       
        public ConsoleAwardPL()
        {
            _bll = DependenciesBLL.AwardBLL;
        }

        public void DisplayAllAwards()
        {
            var users = _bll.GetAllAwards();

            foreach (Awards item in users)
            {
                Console.WriteLine(string.Format("Название: {0}",
                     item.Title));
            }
        }

        public bool AddAward()
        {            
            Console.Write("Введите название награды:");
            string title = Console.ReadLine();
            
            return _bll.SaveAward(new Awards(title));           
        }

        public bool DeleteAward()
        {
            Console.WriteLine("Удаление награды");
            Guid id = SelectedAward();
            return _bll.DeleteAward(id);
        }

        public Guid SelectedAward()
        {
            Dictionary<int, Guid> ID = new Dictionary<int, Guid>();
            var awards = _bll.GetAllAwards();

            Console.WriteLine("Выберите награду:");
            int serialNumber = 1;

            foreach (Awards item in awards)
            {
                Console.WriteLine(string.Format("Награда {0}. Название: {1}",
                    serialNumber, item.Title));
                ID.Add(serialNumber, item.IDAward);
                serialNumber++;
            }
            
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0 && number < serialNumber)
            {
                return ID[number];
            }
            else
            {
                throw new ArgumentOutOfRangeException("number");
            }            
        }
    }
}
