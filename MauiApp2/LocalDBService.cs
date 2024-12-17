using MauiApp2.Models;
using SQLite;

namespace MauiApp2
{
    class LocalDBService
    {
        private readonly SQLiteAsyncConnection _connection;
        public LocalDBService() 
        {
            _connection = new SQLiteAsyncConnection(Constants.DatabasePath);

            _connection.CreateTableAsync<Theme>();
            _connection.CreateTableAsync<Quest>();
            _connection.CreateTableAsync<Post>();
            _connection.CreateTableAsync<User>();
        }

        public async Task<List<Theme>> GetThemes()
        {
            return  await _connection.Table<Theme>().ToListAsync();
        }

        public async Task<Theme> GetThemeById(int id)
        {
            return await _connection.Table<Theme>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateTheme(Theme theme)
        {
            await _connection.InsertAsync(theme);
        }

        public async Task<List<Quest>> GetQuests()
        {
            return await _connection.Table<Quest>().ToListAsync();
        }
        public async Task CreateQuest(Quest quest)
        {
            await _connection.InsertAsync(quest);
        }

        public async Task<List<Post>> GetPosts()
        {
            return await _connection.Table<Post>().ToListAsync();
        }
        public async Task CreatePost(Post post)
        {
            await _connection.InsertAsync(post);
        }

        public async Task<List<User>> GetUsers()
        {
            return await _connection.Table<User>().ToListAsync();
        }
        public async Task CreateUser(User user)
        {
            await _connection.InsertAsync(user);
        }
    }
}
