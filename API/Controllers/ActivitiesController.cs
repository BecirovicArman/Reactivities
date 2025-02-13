using Application.Commands.Activities;
using Application.Queries.Activities;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class ActivitiesController : BaseApiController
{

    [HttpGet] //api/activities
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        return await Mediator.Send(new GetAllActivitiesQuery());
    }

    [HttpGet("{id}")] //api/activities/GUID
    public async Task<ActionResult<Activity>> GetActivity(Guid id)
    {
        return await Mediator.Send(new GetActivityByIdQuery(id));
    }

    [HttpPost]
    public async Task<ActionResult> CreateActivity(Activity activity)
    {
        await Mediator.Send(new CreateActivityCommand(activity));
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateActivity(Guid id, Activity activity)
    {
        activity.Id = id;
        await Mediator.Send(new UpdateActivityCommand(activity));
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteActivity(Guid id)
    {
        await Mediator.Send(new DeleteActivityCommand(id));
        return Ok();
    }
}
