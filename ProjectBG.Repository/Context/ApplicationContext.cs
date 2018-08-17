using Microsoft.EntityFrameworkCore;
using ProjektBG.Domain.Models;

namespace ProjectBG.Repository.Context
{
    public class BoardGameContext : DbContext
    {
        //default constructor, expectiong db option passed in
        //Dep. Injection need
        public BoardGameContext(DbContextOptions<BoardGameContext> options)
            :base(options)
        {
            
        }

        //Default constructor
        public BoardGameContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            base.OnConfiguring(optionBuilder);

            optionBuilder.UseSqlite("Data Source = AppBG.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Advertisement> Advertisements { get; set; }
        public virtual DbSet<AdvertisementComment> AdvertisementComments { get; set; }
        public virtual DbSet<AdvertisementRating> AdvertisementRatings { get; set; }

        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventComment> EventComments { get; set; }
        public virtual DbSet<EventParticipant> EventParticipants { get; set; }
        public virtual DbSet<EventRating> EventRatings { get; set; }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<UserRating> UserRatings { get; set; }

        public virtual DbSet<Chat> Chats { get; set; }
        public virtual DbSet<ChatParticipant> ChatParticipants { get; set; }

        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GameCategory> GameCategories { get; set; }
        public virtual DbSet<GameRating> GameRatings { get; set; }
        public virtual DbSet<OwnedGame> OwnedGames { get; set; }

        public virtual DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        public virtual DbSet<SearchHistory> SearchHistories { get; set; }

    }
}
