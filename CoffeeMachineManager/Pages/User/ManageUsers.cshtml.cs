using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoffeeMachineManager.Data;
using CoffeeMachineManager.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ManageUsersModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public ManageUsersModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<User> Users { get; set; }

    public async Task OnGetAsync()
    {
        Users = await _context.Users.ToListAsync();
    }
}
