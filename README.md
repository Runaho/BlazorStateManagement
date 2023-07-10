
# BlazorStateManagement

https://github.com/Runaho/BlazorStateManagement/assets/16222645/a9864563-1492-4cd9-a995-52973482f0e0

Greetings,
I didn't pay much attention because I wanted to prepare a quick example.

The reason I'm pulling data in OnAfterRender is that on init methods are not triggered from StateHasChanged.

Normally I would pull the data directly before the handler and then run StateHasChanged, but I didn't do it there for a fair test.

When there is more than one client, we already get an error directly.
