﻿public class Robot : IId
{
    public Robot(string model, string id)
    {
        this.Model = model;
        this.Id = id;
    }

    public string Id { get; private set; }

    public string Model { get; private set; }
}
