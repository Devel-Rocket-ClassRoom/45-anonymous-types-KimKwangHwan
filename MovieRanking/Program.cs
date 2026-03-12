using System;

string title = "인터스텔라";
string genre = "SF";
double rating = 9.2;
int releaseYear = 2024;

var movie_info = new
{
    title,
    genre,
    rating,
    releaseYear
};

Console.WriteLine("=== 영화 정보 ===");
Console.WriteLine($"제목: {movie_info.title}");
Console.WriteLine($"장르: {movie_info.genre}");
Console.WriteLine($"평점: {movie_info.rating}");
Console.WriteLine($"개봉연도: {movie_info.releaseYear}");

Console.WriteLine();
Console.WriteLine("ToString 결과");
Console.WriteLine(movie_info.ToString());