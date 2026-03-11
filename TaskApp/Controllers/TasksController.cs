using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskApp.Data;
using TaskApp.Domain;


[ApiController]
[Route("api/tasks")]
public class TasksController : ControllerBase
{
    private readonly AppDbContext _context;

    public TasksController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateTaskDto dto)
    {
        try
        {
            var task = new WorkTask(dto.Title, dto.Description, dto.Priority);

            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();

            return Ok(task);
        }
        catch (DbUpdateException)
        {
            return Conflict(new ProblemDetails
            {
                Title = "Duplicate ",
                Detail = "A task with this title exists"
            });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new ProblemDetails
            {
                Title = "Validation Error",
                Detail = ex.Message
            });
        }
    }

    [HttpGet]
    
    public async Task 
    <IActionResult>Get()
    {
        await Task.Delay(3000);
        var tasks = await _context.Tasks.ToListAsync();
        return Ok(tasks);

    }
    
}