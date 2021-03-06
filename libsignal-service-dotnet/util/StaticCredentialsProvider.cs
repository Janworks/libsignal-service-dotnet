/**
 * Copyright (C) 2015 smndtrl
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace libsignalservice.util
{
    public class StaticCredentialsProvider : CredentialsProvider
    {
        private string Username;
        private string Password;
        private string SignalingKey;
        private int DeviceId;

        public StaticCredentialsProvider(string user, string password, string signalingKey, int deviceId)
        {
            Username = user;
            Password = password;
            SignalingKey = signalingKey;
            DeviceId = deviceId;
        }

        public string GetUser()
        {
            return Username;
        }

        public string GetPassword()
        {
            return Password;
        }

        public string GetSignalingKey()
        {
            return SignalingKey;
        }

        public int GetDeviceId()
        {
            return DeviceId;
        }
    }
}
