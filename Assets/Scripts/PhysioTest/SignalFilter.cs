using UnityEngine;

namespace PhysioTest
{
    public interface IFilter
    {
        Vector3 Filter(Vector3 rawPosition);
    }

    public class PositionFilter : IFilter
    {
        // TODO: TASK 2 - SIGNAL SMOOTHING
        // Implement a smoothing algorithm here (e.g., Moving Average, OneEuro, Kalman).
        // The goal is to reduce jitter from the raw input.
        
        // Hint: You may need a Queue or variables to store previous frames.

        public Vector3 Filter(Vector3 rawPosition)
        {
            // Currently just returns raw data (no filtering)
            return rawPosition; 
        }
    }
}