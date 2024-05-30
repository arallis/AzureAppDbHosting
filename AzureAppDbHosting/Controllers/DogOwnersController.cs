using AzureAppDbHosting.Data;
using AzureAppDbHosting.Models;
using Microsoft.AspNetCore.Mvc;

public class DogOwnersController : Controller
{
    private readonly ApplicationDbContext _context;

    public DogOwnersController(ApplicationDbContext context)
    {
        _context = context;
    }

    // POST: DogOwners/CreateDogOwner
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateDogOwner([Bind("OwnerID,FirstName,LastName,Email,PhoneNumber,DogName,DogBreed,DogAge,Address")] DogOwner dogOwner)
    {
        if (ModelState.IsValid)
        {
            _context.Add(dogOwner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index)); // Redirect to a list page or details page
        }
        return View(dogOwner); // Return the view with validation errors
    }
}