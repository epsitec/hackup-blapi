# hackup-blapi

Hackup inspired by Daniel Roux's Blupi character (see [his sample code used to learn how to write a game in JavaScript](https://github.com/SpeedyBlupi/hackup-game2.git)), but with Blazor. Basically, the code uses `Blazor.Extensions.Canvas` and `requestAnimationFrame()` to call into Blazor.

![Blupi Character](https://github.com/epsitec/hackup-blapi/blob/master/Client/wwwroot/art/80x80/i002.png)

## Wiring in index.html

```js
function renderJS(timeStamp) {
    theInstance.invokeMethodAsync('RenderInBlazor', timeStamp);
    window.requestAnimationFrame(renderJS);
}
```

## Implementation in Blazor

```cs
[JSInvokable]
public async ValueTask RenderInBlazor(float timeStamp)
{
    // ...
}
```
