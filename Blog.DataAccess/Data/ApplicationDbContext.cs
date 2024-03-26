using Blog.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> UserProperties { get; set; }
        public DbSet<Post> PostProperties { get; set; }
        public DbSet<PostReply> PostReplyProperties { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User { Name="Adrian",profile_description = "lalala 1 2 3",created_at = DateTime.Now},
                 new User { Name="jijel",profile_description = "razvan 1 2 3",created_at = DateTime.Now},
                 new User { Name="ciaciu",profile_description = "adrian 1 2 3", created_at = DateTime.Now }

                );

            modelBuilder.Entity<Post>().HasData(
                //new Post { Unique_Id_Post = 1,author_user_id= "7e245a45-352d-4486-98c4-035eecf15875", content = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", content_title = "REACT FRONT?", created_at = DateTime.Now },
                //new Post { Unique_Id_Post = 2,author_user_id= "a2eb4331-a44e-4652-aeee-140ce222f37e", content = "n looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", content_title = "WORLD OF WARCRAFT BEST MMO", created_at = DateTime.Now},
                //new Post { Unique_Id_Post = 3, author_user_id = "bad532d4-d537-415b-bc4d-b4718a3dd162", content = "Itoking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", content_title = "SOMETHING", created_at = DateTime.Now },
                //new Post { Unique_Id_Post = 4, author_user_id = "e5a74233-81d1-4874-8fe7-a87e5fedb3d0", content = "Iis a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", content_title = "WHY WHY WHY?", created_at = DateTime.Now },
                //new Post { Unique_Id_Post = 5,author_user_id= "e5a74233-81d1-4874-8fe7-a87e5fedb3d0", content = "It is a long established fact that a reader will be distr ", content_title = ".NET BLOG ?", created_at = DateTime.Now},
                //new Post { Unique_Id_Post = 6, author_user_id = "62b303f6-6e23-4dd6-915b-8ec1559ebb48", content = "It is a long es ", content_title = "With whom should we use it?", created_at = DateTime.Now},
                //new Post { Unique_Id_Post = 7,author_user_id= "a8adb7ad-d3c6-446b-898b-d26ccc26987d", content = "Lalala", content_title = "What is Lorem Impsum ?", created_at = DateTime.Now},
                new Post { Unique_Id_Post = 8, author_user_id = "62b303f6-6e23-4dd6-915b-8ec1559ebb48", DisplayName="Mariusica", content = "Ce sa faci atunci cand te doare capul ?  ", content_title = "Doare capul ?", created_at = DateTime.Now}

                );

            modelBuilder.Entity<PostReply>().HasData(
                new PostReply { PostReplyId = 1, PostId = 4, username = "adrian", content = " !!!!!!! CE TAREE EEEE!", created_at = DateTime.Now, last_modified = DateTime.Now, likes = 0 },
                new PostReply { PostReplyId = 2, PostId = 2, username = "adrian", content = " haha, ce tare !", created_at = DateTime.Now, last_modified = DateTime.Now, likes = 0 },
                new PostReply { PostReplyId = 3, PostId = 3, username = "razvan", content = " wow, incredibil", created_at = DateTime.Now, last_modified = DateTime.Now, likes = 1 },
                new PostReply { PostReplyId = 4, PostId = 4, username = "raymond", content = " haha, senzational!", created_at = DateTime.Now, last_modified = DateTime.Now, likes = 1 }
                );

            modelBuilder.Entity<Post>()
              .HasOne(p => p.User)
              .WithMany(p => p.Posts)
              .HasForeignKey(p => p.author_user_id)
              .IsRequired();
        }
    }



    
}
