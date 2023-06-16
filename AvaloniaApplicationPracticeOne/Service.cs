using AvaloniaApplicationPracticeOne.Models;

namespace AvaloniaApplicationPracticeOne;

public class Service
{
    // Переменная хранит экземпляр контекста
    private static PostgresContext? _db;

    // Метод, если экземпляр еще не создан, создает и возвращает его
    // Если экземпляр создан, возвращает его
    public static PostgresContext  GetDbContext()
    {
        if (_db == null)
        {
            _db = new PostgresContext();
        }
        return _db;
    }
}
