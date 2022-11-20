using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuAPI;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;
using CitizenFX.Core.Native;
using static System.TimeZoneInfo;

namespace RedMenuClient
{
    static class Util
    {

        /// <summary>
		/// Shows a subtitle at the bottom of the screen for a given time.
        /// It's not actually a Subtitle, but rather, it sets an objective.
		/// </summary>
		/// <param name="message">The message to display.</param>
		public static void ShowSubtitle(string message)
        {
            string varString = Function.Call<string>(Hash._CREATE_VAR_STRING, 10, "LITERAL_STRING", message);
            Function.Call((Hash)0xFA233F8FE190514C, varString); //_UILOG_SET_CACHED_OBJECTIVE
            Function.Call((Hash)0xE9990552DEC71600); //_UILOG_PRINT_CACHED_OBJECTIVE
            Function.Call((Hash)0xDFF0D417277B41F8); //_UILOG_CLEAR_CACHED_OBJECTIVE
        }

        /// <summary>
        /// Returns true if the control is pressed.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsControlPressed(Control control)
        {
            if (Function.Call<bool>(Hash.IS_CONTROL_PRESSED, 0, (uint)control))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true if the control is just pressed.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsControlJustPressed(Control control)
        {
            if (Function.Call<bool>(Hash.IS_CONTROL_JUST_PRESSED, 0, (uint)control))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true if the disabled control is pressed.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsDisabledControlPressed(Control control)
        {
            if (Function.Call<bool>(Hash.IS_DISABLED_CONTROL_PRESSED, 0, (uint)control))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true if the disabled control is just pressed.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsDisabledControlJustPressed(Control control)
        {
            if (Function.Call<bool>(Hash.IS_DISABLED_CONTROL_JUST_PRESSED, 0, (uint)control))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true if the control is released.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsControlReleased(Control control)
        {
            if (Function.Call<bool>(Hash.IS_CONTROL_RELEASED, 0, (uint)control))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true if the control is just released.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsControlJustReleased(Control control)
        {
            if (Function.Call<bool>(Hash.IS_CONTROL_JUST_RELEASED, 0, (uint)control))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true if the disabled control is released.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsDisabledControlReleased(Control control)
        {
            if (Function.Call<bool>(Hash.IS_DISABLED_CONTROL_PRESSED, 0, (uint)control))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Returns true if the disabled control is just released.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsDisabledControlJustReleased(Control control)
        {
            if (Function.Call<bool>(Hash.IS_DISABLED_CONTROL_JUST_RELEASED, 0, (uint)control))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true if the control is enabled.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsControlEnabled(Control control)
        {
            return Function.Call<bool>(Hash.IS_CONTROL_ENABLED, 0, (uint)control);
        }

    }
}
