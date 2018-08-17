using ProjectBG.Repository.Context;
using ProjektBG.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBG.Api.Data
{
    public class GameCategoryDataHandler
    {
        public IEnumerable<GameCategory> GetAll()
        {
            IEnumerable<GameCategory> gameCategories = null;
            using (BoardGameContext context = new BoardGameContext())
            {
                gameCategories = context.GameCategories
                    //.Where(x => x.Name.StartsWith("A"))
                    .Select(gameCategory => gameCategory);
            }
            return gameCategories;
        }


    }
}
