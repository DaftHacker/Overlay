using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;

namespace KeyState
{
    public class KeyListener
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern bool GetAsyncKeyState(int vkey);

        public static bool GetKeyState(vkey Key)
        {
            return GetAsyncKeyState((int)Key);
        }
        public static string GetActiveKeys()
        {
            string CurrentButtonDown = "";

            #region MouseButtons
            if (GetKeyState(vkey.LeftMouseButton) == true)
            {
                CurrentButtonDown += "|LeftMouseButton|";
            }
            if (GetKeyState(vkey.RightMouseButton) == true)
            {
                CurrentButtonDown += "|RightMouseButton|";
            }
            if (GetKeyState(vkey.MiddleMouseButton) == true)
            {
                CurrentButtonDown += "|MiddleMouseButton|";
            }
            #endregion

            #region Numbers
            if (GetKeyState(vkey.Number0) == true)
            {
                CurrentButtonDown += "|0|";
            }
            if (GetKeyState(vkey.Number1) == true)
            {
                CurrentButtonDown += "|1|";
            }
            if (GetKeyState(vkey.Number2) == true)
            {
                CurrentButtonDown += "|2|";
            }
            if (GetKeyState(vkey.Number3) == true)
            {
                CurrentButtonDown += "|3|";
            }
            if (GetKeyState(vkey.Number4) == true)
            {
                CurrentButtonDown += "|4|";
            }
            if (GetKeyState(vkey.Number5) == true)
            {
                CurrentButtonDown += "|5|";
            }
            if (GetKeyState(vkey.Number6) == true)
            {
                CurrentButtonDown += "|6|";
            }
            if (GetKeyState(vkey.Number7) == true)
            {
                CurrentButtonDown += "|7|";
            }
            if (GetKeyState(vkey.Number8) == true)
            {
                CurrentButtonDown += "|8|";
            }
            if (GetKeyState(vkey.Number9) == true)
            {
                CurrentButtonDown += "|9|";
            }
            #endregion

            #region Letters
            if (GetKeyState(vkey.A) == true)
            {
                CurrentButtonDown += "|A|";
            }
            if (GetKeyState(vkey.B) == true)
            {
                CurrentButtonDown += "|B|";
            }
            if (GetKeyState(vkey.C) == true)
            {
                CurrentButtonDown += "|C|";
            }
            if (GetKeyState(vkey.D) == true)
            {
                CurrentButtonDown += "|D|";
            }
            if (GetKeyState(vkey.E) == true)
            {
                CurrentButtonDown += "|E|";
            }
            if (GetKeyState(vkey.F) == true)
            {
                CurrentButtonDown += "|F|";
            }
            if (GetKeyState(vkey.G) == true)
            {
                CurrentButtonDown += "|G|";
            }
            if (GetKeyState(vkey.H) == true)
            {
                CurrentButtonDown += "|H|";
            }
            if (GetKeyState(vkey.I) == true)
            {
                CurrentButtonDown += "|I|";
            }
            if (GetKeyState(vkey.J) == true)
            {
                CurrentButtonDown += "|J|";
            }
            if (GetKeyState(vkey.K) == true)
            {
                CurrentButtonDown += "|K|";
            }
            if (GetKeyState(vkey.L) == true)
            {
                CurrentButtonDown += "|L|";
            }
            if (GetKeyState(vkey.M) == true)
            {
                CurrentButtonDown += "|M|";
            }
            if (GetKeyState(vkey.N) == true)
            {
                CurrentButtonDown += "|N|";
            }
            if (GetKeyState(vkey.O) == true)
            {
                CurrentButtonDown += "|O|";
            }
            if (GetKeyState(vkey.P) == true)
            {
                CurrentButtonDown += "|P|";
            }
            if (GetKeyState(vkey.Q) == true)
            {
                CurrentButtonDown += "|Q|";
            }
            if (GetKeyState(vkey.R) == true)
            {
                CurrentButtonDown += "|R|";
            }
            if (GetKeyState(vkey.S) == true)
            {
                CurrentButtonDown += "|S|";
            }
            if (GetKeyState(vkey.T) == true)
            {
                CurrentButtonDown += "|T|";
            }
            if (GetKeyState(vkey.U) == true)
            {
                CurrentButtonDown += "|U|";
            }
            if (GetKeyState(vkey.V) == true)
            {
                CurrentButtonDown += "|V|";
            }
            if (GetKeyState(vkey.W) == true)
            {
                CurrentButtonDown += "|W|";
            }
            if (GetKeyState(vkey.X) == true)
            {
                CurrentButtonDown += "|X|";
            }
            if (GetKeyState(vkey.Y) == true)
            {
                CurrentButtonDown += "|Y|";
            }
            if (GetKeyState(vkey.Z) == true)
            {
                CurrentButtonDown += "|Z|";
            }
            #endregion

            #region Numpad
            if (GetKeyState(vkey.NumPad0) == true)
            {
                CurrentButtonDown += "|Numpad 0|";
            }
            #endregion

            //Special Keys
            if (GetKeyState(vkey.PageUp) == true)
            {
                CurrentButtonDown += "|Page Up|";
            }
            if (GetKeyState(vkey.PageDown) == true)
            {
                CurrentButtonDown += "|Page Down|";
            }
            if (GetKeyState(vkey.End) == true)
            {
                CurrentButtonDown += "|End|";
            }
            if (GetKeyState(vkey.Home) == true)
            {
                CurrentButtonDown += "|Home|";
            }

            //Testing
            if (GetKeyState(vkey.Space) == true)
            {
                CurrentButtonDown += "|Space|";
            }
            if (GetKeyState(vkey.Tab) == true)
            {
                CurrentButtonDown += "|Tab|";
            }
            return CurrentButtonDown;
        }
    }

    public enum vkey : uint
    {
        //Mouse Buttons
        LeftMouseButton = 0x01,
        RightMouseButton = 0x02,
        MiddleMouseButton = 0x04,
        X1MouseButton = 0x05,
        X2MouseButton = 0x06,


        Backspace = 0x08,
        Tab = 0x09,
        Enter = 0x0D,
        Space = 0x20,

        //Numbers
        Number0 = 0x30,
        Number1 = 0x31,
        Number2 = 0x32,
        Number3 = 0x33,
        Number4 = 0x34,
        Number5 = 0x35,
        Number6 = 0x36,
        Number7 = 0x37,
        Number8 = 0x38,
        Number9 = 0x39,

        //Letters
        A = 0x41,
        B = 0x42,
        C = 0x43,
        D = 0x44,
        E = 0x45,
        F = 0x46,
        G = 0x47,
        H = 0x48,
        I = 0x49,
        J = 0x4A,
        K = 0x4B,
        L = 0x4C,
        M = 0x4D,
        N = 0x4E,
        O = 0x4F,
        P = 0x50,
        Q = 0x51,
        R = 0x52,
        S = 0x53,
        T = 0x54,
        U = 0x55,
        V = 0x56,
        W = 0x57,
        X = 0x58,
        Y = 0x59,
        Z = 0x5A,

        //Numpad
        NumPad0 = 0x60,
        NumPad1 = 0x61,
        NumPad2 = 0x62,
        NumPad3 = 0x63,
        NumPad4 = 0x64,
        NumPad5 = 0x65,
        NumPad6 = 0x66,
        NumPad7 = 0x67,
        NumPad8 = 0x68,
        NumPad9 = 0x69,

        //Special Keys
        PageUp = 0x21,
        PageDown = 0x22,
        End = 0x23,
        Home = 0x24,
    }

    //Not Used
    //public enum Vkey : uint
    //{
    //    VK_LBUTTON = 0x01, //Left mouse button
    //    VK_RBUTTON = 0x02, //Right mouse button
    //    VK_CANCEL = 0x03, //Control-break processing
    //    VK_MBUTTON = 0x04, //Middle mouse button (three-button mouse)
    //    VK_XBUTTON1 = 0x05, //X1 mouse button
    //    VK_XBUTTON2 = 0x06, //X2 mouse button
    //    //0x07 Undefined
    //    VK_BACK = 0x08, //BACKSPACE key
    //    VK_TAB = 0x09, //TAB key
    //    //0x0A & 0x0B Reserved
    //    VK_CLEAR = 0x0C, //CLEAR key
    //    VK_RETURN = 0x0D, //ENTER key
    //    //0x0E & 0x0F Undefined
    //    VK_SHIFT = 0x10, //SHIFT key
    //    VK_CONTROL = 0x11, //CTRL key
    //    VK_MENU = 0x12, //ALT key
    //    VK_PAUSE = 0x13, //PAUSE key
    //    VK_CAPITAL = 0x14, //CAPS LOCK key

    //}
}
