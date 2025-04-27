# Personal TikTok Video Uploader

This repository contains a simple .NET Worker Service designed to automate the posting of videos to **my personal TikTok account**. It's created exclusively for private use and not intended for public or third-party access.

---

## Overview
This .NET-based mini-worker automates:
- Posting videos to TikTok via the TikTok API.
- Simplifying repetitive upload tasks by scheduling uploads.

---

## Purpose
- Streamline my personal video upload workflow.
- Automate daily or scheduled TikTok video uploads securely and privately.

---

## Technologies Used
- .NET Worker Service (.NET 8+)
- RestSharp (for API requests)
- Newtonsoft.Json (JSON handling)
- TikTok Official API (Content Posting API v2)

---

## Requirements
- **.NET 8 SDK** or newer ([Download .NET](https://dotnet.microsoft.com/download))
- **TikTok App Credentials**:
  - Client ID
  - Client Secret
  - OAuth Access Token (`video.publish` permission)
- Videos must be in MP4 or MOV format, meeting [TikTok Video Guidelines](https://developers.tiktok.com/doc/content-posting-api/).

---

## Setup Instructions

1. **Clone the Repository**
``git clone https://github.com/yourusername/tiktok-uploader.git``
   
3. **Restore Dependencies**
``cd tiktok-uploader
   dotnet restore``

4. **Configure the Application Update the following in Worker.cs or through environment variables:**
``string accessToken = "YOUR_ACCESS_TOKEN";
   string videoFilePath = "path/to/your/video.mp4";
   string videoDescription = "Your video caption here";``

5. **Run the Worker**
``dotnet run``
