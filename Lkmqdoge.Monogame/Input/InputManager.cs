using System.Collections.Generic;

using Lkmqdoge.Monogame.Utils;

namespace Lkmqdoge.Monogame.Input;

public class InputManager
{
    public KeyBoardInfo KeyBoardInfo { get; private set; } = new();
    public MouseInfo    MouseInfo    { get; private set; } = new();

    private readonly Dictionary<string, InputAction> _actions = [];
    
    public void AddAction(params InputAction[] actions)
    {
        foreach (var action in actions)
            _actions.Add(action.Name, action);
    }

    public void Update()
    {
        KeyBoardInfo.Update();
        MouseInfo.Update();
    }

    public bool IsActionJustPressed(string actionName)
    {
        if (_actions.TryGetValue(actionName, out var action))
        {
            var c = 0;
            foreach(var key in action.Keys)
                if (KeyBoardInfo.IsKeyJustPressed(key))
                    c++;
            
            return c > 0;
        }
        else
        {
            Logger.Error($"action {actionName} does not exist");
            return false;
        }
    }

    public bool IsActionPressed(string actionName)
    {
        if (_actions.TryGetValue(actionName, out var action))
        {
            var c = 0;
            foreach(var key in action.Keys)
                if (KeyBoardInfo.IsKeyDown(key))
                    c++;
            
            return c > 0;
        }
        else
        {
            Logger.Error($"action {actionName} does not exist");
            return false;
        }
    }
}