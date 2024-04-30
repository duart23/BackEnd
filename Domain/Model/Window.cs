namespace Domain.Model
{
    using System.ComponentModel.DataAnnotations;

    public class Window
    {
        [Key]
        public int WindowId { get; set; }
        public bool IsOpen { get; set; } // Make it settable

        // Parameterless constructor
        public Window() { }

        // Constructor with all properties
        public Window(int windowId, bool isOpen)
        {
            WindowId = windowId;
            IsOpen = isOpen;
        }
        
        public void changeStatus()
        {
            IsOpen = !IsOpen;
        }

    }
}

