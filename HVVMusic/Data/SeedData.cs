
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HVVMusic.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace HVVMusic.Data
{
    public class SeedData
    {
        public static void EnsurePopulate(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Musics.Any())
            {
                context.Musics.AddRange(
                    new Music
                    {
                        Name = "Không Muốn Yêu Lại Càng Say Đắm",
                        Author = "Mrsiro",
                        ReleaseDate = "06/01/2021",
                        Likes = 100,
                        Price = 1000,
                        UrlImage = "Mrsiro.jpg"


                    },
                    new Music
                    {
                        Name = "Hạnh Phúc Bỏ Rơi Em",
                        Author = "Hương ly",
                        ReleaseDate = "06/01/2021",
                        Likes = 100
                        ,
                        Price = 1000,
                        UrlImage = "huongly.jpg"

                    },
                    new Music
                    {
                        Name = "Gặp Nhưng Không Ở Lại",
                        Author = "Hiền Hồ",
                        ReleaseDate = "06/01/2021",
                        Likes = 100
                        ,
                        Price = 1000,
                        UrlImage = "Hienho.jpg"
                    },
                    new Music
                    {
                        Name = "Chiều Thu Hạo Bóng Nàng",
                        Author = "ĐatKaa",
                        ReleaseDate = "06/01/2021",
                        Likes = 100
                        ,
                        Price = 1000
                         ,
                        UrlImage = "datkaa.jpg"
                    },
                    new Music
                    {
                        Name = "Chẳng Thể Tìm Được Em",
                        Author = "PhucXP,Freak D",
                        ReleaseDate = "06/01/2021",
                        Likes = 100
                        ,
                        Price = 1000
                         ,
                        UrlImage = "PhucXp.jpg"
                    },
                    new Music
                    {
                        Name = "Xa Một Người Còn Thương",
                        Author = "Du Thiên,AVC",
                        ReleaseDate = "06/01/2021",
                        Likes = 100
                        ,
                        Price = 1000
                         ,
                        UrlImage = "duthien.jpg"
                    },
                    new Music
                    {
                        Name = "Kẻ Ngu Yêu Lại Người Cũ",
                        Author = "Vĩnh Thuyên Kim",
                        ReleaseDate = "06/01/2021",
                        Likes = 100
                        ,
                        Price = 1000
                         ,
                        UrlImage = "vinhthuyenkim.jpg"
                    },
                    new Music
                    {
                        Name = "Đô Trưởng               ",
                        Author = "Đạt G",
                        ReleaseDate = "06/01/2021",
                        Likes = 100
                        ,
                        Price = 1000
                         ,
                        UrlImage = "datG.jpg"
                    },
                    new Music
                    {
                        Name = "Anh Từng Cố Gắng",
                        Author = "Nhật Phong",
                        ReleaseDate = "06/01/2021",
                        Likes = 100
                        ,
                        Price = 1000
                         ,
                        UrlImage = "nhatphong.jpg"
                    },
                    new Music
                    {
                        Name = "Đom Đóm          ",
                        Author = "Jack.jpg",
                        ReleaseDate = "06/01/2021",
                        Likes = 100
                        ,
                        Price = 1000
                        ,
                        UrlImage = "Jack.jpg"

                    });
                context.SaveChanges();
            }
        }
    }
}
