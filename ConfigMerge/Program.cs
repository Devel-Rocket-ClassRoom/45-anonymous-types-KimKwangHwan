using System;

var normal_setting = new { ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 50, Difficulty = "보통" };
var user_setting = new { ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 80, Difficulty = "어려움" };

Console.WriteLine($"[기본 설정]\n{normal_setting}\n");
Console.WriteLine($"[사용자 설정]\n{user_setting}\n");

Console.WriteLine($"[타입 비교]\n같은 타입: {normal_setting.GetType() == user_setting.GetType()}\n");
Console.WriteLine($"[값 비교]\nEquals 결과: {normal_setting.Equals(user_setting)}\n");

var backup_setting = new { ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 50, Difficulty = "보통" };

Console.WriteLine($"[백업 설정]\n{backup_setting}\n");
Console.WriteLine($"기본 설정과 Equals: {normal_setting.Equals(backup_setting)}\n");

var arr = new[]
{
    normal_setting,
    user_setting,
    backup_setting
};
Console.WriteLine("=== 설정 목록 (배열) ===");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"설정 {i + 1}: {arr[i].ResolutionWidth}x{arr[i].ResolutionHeight}, 볼륨: {arr[i].Volume}, 난이도 {arr[i].Difficulty}");
}
Console.WriteLine("\n=== 속성 순서가 다른 설정 ===");
var new_setting = new { Volume = 50, Difficulty = "보통", ResolutionWidth = 1920, ResolutionHeight = 1080 };
Console.WriteLine($"{new_setting}");
Console.WriteLine($"타입 비교: {normal_setting.GetType() == new_setting.GetType()}");