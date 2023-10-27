
# BlazorStateManagement


Greetings,

The main goal here is to be able to trigger other clients with a singleton state container rather than creating a new hub since Blazor has already opened the SignalR socket.
When you look at it this way, it actually provides a really easy implementation.
I think with this approach, we are already using the advantage of the Blazor Server application running on a single server and we are building a pusher-like structure.

The reason I'm pulling data in OnAfterRender is that on init methods are not triggered from StateHasChanged.
Normally I would pull the data directly before the handler and then run StateHasChanged, but I didn't do it there for a fair test.
When there is more than one client, we already get an error directly. But using InvokeAsync we can fix that issue.


https://github.com/Runaho/BlazorStateManagement/assets/16222645/88420c5f-9405-4769-8b4c-a538322409d3

