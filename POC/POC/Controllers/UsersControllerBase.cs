using Microsoft.AspNetCore.Mvc;

namespace POC.Controllers
{
    [ApiController, Route("api/users")]
    public class UsersControllerBase
    {

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exists = await context.Users.AnyAsync(x => x.user_id == id);
            if (!exists)
            {
                //return NotFound();
            }

            context.Remove(new Users() { user_id = id });
            await context.SaveChangesAsync();

            // return NoContent();
        }
    }
}