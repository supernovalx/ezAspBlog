using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ezAspBlog.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BlogContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BlogContext>>()))
            {
                // Look for any movies.
                if (context.Posts.Any())
                {
                    return;   // DB has been seeded
                }

                context.Posts.AddRange(
                    new Post{
                        Title = "Esse proident eu aliqua cupidatat nisi eu quis cupidatat sint ut id ea fugiat adipisicing.",
                        Content = "Consequat et reprehenderit qui mollit Lorem elit minim ea adipisicing cillum consectetur elit. Fugiat ea mollit cillum et id. Irure deserunt sunt aliqua sit reprehenderit ullamco sit ex amet amet do pariatur ullamco. Id laborum enim ea fugiat exercitation nulla pariatur velit. Eiusmod quis voluptate est sint anim in irure occaecat proident cupidatat sunt officia aute mollit. Aute Lorem anim consectetur amet elit labore Lorem excepteur duis sunt dolor deserunt adipisicing est.",
                        Author = "SuperNovalx",
                        Comments = new List<Comment>{
                            new Comment {
                                Author = "guest1",
                                Content = "noice"
                            },
                            new Comment {
                                Author = "theboi",
                                Content = "sweet"
                            }
                        }
                    },
                    new Post{
                        Title = "Esse proident eu aliqua cupidatat nisi eu quis cupidatat sint ut id ea fugiat adipisicing.",
                        Content = "Consequat et reprehenderit qui mollit Lorem elit minim ea adipisicing cillum consectetur elit. Fugiat ea mollit cillum et id. Irure deserunt sunt aliqua sit reprehenderit ullamco sit ex amet amet do pariatur ullamco. Id laborum enim ea fugiat exercitation nulla pariatur velit. Eiusmod quis voluptate est sint anim in irure occaecat proident cupidatat sunt officia aute mollit. Aute Lorem anim consectetur amet elit labore Lorem excepteur duis sunt dolor deserunt adipisicing est.",
                        Author = "awmdiom awdiniov",
                        Comments = new List<Comment>{
                            new Comment {
                                Author = "v8e68",
                                Content = "vvvveveve"
                            },
                            new Comment {
                                Author = "vevevwevrehthym",
                                Content = "dcwevf8we2 gwe84 6w84e"
                            }
                        }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}