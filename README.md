
# BlazorStateManagement


Greetings,
I didn't pay much attention because I wanted to prepare a quick example.

The reason I'm pulling data in OnAfterRender is that on init methods are not triggered from StateHasChanged.

Normally I would pull the data directly before the handler and then run StateHasChanged, but I didn't do it there for a fair test.

When there is more than one client, we already get an error directly.


https://github.com/Runaho/BlazorStateManagement/assets/16222645/88420c5f-9405-4769-8b4c-a538322409d3

