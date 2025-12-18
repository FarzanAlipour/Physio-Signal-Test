using System;

namespace PhysioTest
{
    // TODO: TASK 1 - JSON PARSING
    // 1. Analyze '2_7-insufficient-rom.json' in StreamingAssets.
    // 2. Define the C# classes below to deserialize the data.
    
    [Serializable]
    public class PoseRecording
    {
        // Example: public List<Frame> frames;
    }
    
    [Serializable]
    public class Frame 
    {
        // Example: public float timestamp;
        // Example: public List<Landmark> landmarks;
    }

    [Serializable]
    public class Landmark
    {
        // Example: x, y, z, visibility
    }
}