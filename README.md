# Job Posting Slack Bot

The Job Posting Slack Bot is a custom Slack bot designed to automate the posting of job openings to a dedicated Slack channel. It integrates with the SourceStack API to retrieve job posting data and uses OpenAI's GPT technology to generate cover letter suggestions based on the job postings.

## Features

- Automated job posting: The bot fetches job posting data from SourceStack API and posts random job openings to the designated Slack channel.
- Posting frequency control: Set specific intervals for posting job openings throughout the day to maintain a balanced frequency.
- cover letter suggestions: Utilizes OpenAI's GPT technology to generate personalized cover letter key points based on the job postings.
- Easy setup: Follow the instructions in the documentation to quickly configure and deploy the bot in your Slack workspace.

# Job Posting Slack Bot Documentation

The Job Posting Slack Bot is a powerful tool designed to automate the process of posting job openings to a dedicated Slack channel. This documentation will guide you through the setup and usage of the bot, enabling you to streamline your job posting workflow within Slack.

## Table of Contents

1. [Introduction](#introduction)
2. [Getting Started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Installation](#installation)
3. [Configuration](#configuration)
    - [API Setup](#api-setup)
    - [Slack Integration](#slack-integration)
4. [Usage](#usage)
    - [Posting Job Openings](#posting-job-openings)
    - [Setting Frequency](#setting-frequency)
    - [Generating Resume and Cover Letter](#generating-resume-and-cover-letter)
5. [Contributing](#contributing)
6. [License](#license)

## Introduction

The Job Posting Slack Bot is a powerful tool that fetches job posting data from the SourceStack API and posts random job openings to a designated Slack channel. It also utilizes OpenAI's GPT technology to generate key points for resume and cover letter creation based on the job postings. This bot aims to simplify the job posting process and enhance collaboration within your Slack workspace.

## Getting Started

### Prerequisites

Before you begin, ensure that you have the following:

- Slack workspace with appropriate permissions to add and configure bots.
- SourceStack API key to retrieve job posting data.
- OpenAI API key for utilizing GPT technology.

### Installation

1. Clone the repository to your local machine:

   ```bash
   git clone https://github.com/your-username/job-posting-slack-bot.git
   ```

2. Install the required dependencies using a package manager:

   ```bash
   cd job-posting-slack-bot
   dotnet restore
   ```

3. Update the configuration files with your API keys and desired settings.

4. Build the project:

   ```bash
   dotnet build
   ```

5. Run the bot:

   ```bash
   dotnet run
   ```

## Configuration

### API Setup

To retrieve job posting data from the SourceStack API, follow these steps:

1. Sign up for a SourceStack API key at [sourcestack.com/api](https://www.sourcestack.com/api).

2. Update the `program.cs` file with your SourceStack API key:

   ```json
   {
     private static readonly string SourceStackApiUrl = "YOUR_API_KEY";
   }
   ```

### Slack Integration

To configure the Slack integration for the bot, perform the following:

1. Create a new Slack app in your workspace and grant it the necessary permissions to access the desired channels.

2. Obtain the Slack Bot Token for your app and update the `appsettings.json` file:

   ```json
   {
     private static readonly string slackApiToken = "YOUR_BOT_TOKEN";
   }
   ```

3. Set up the desired Slack channel where the job postings will be posted and note its channel ID.

4. Update the `appsettings.json` file with the Slack channel ID:

   ```json
   {
     private static readonly string channelId = "YOUR_CHANNEL_ID";
   }
   ```

## Usage

### Posting Job Openings

The bot automatically fetches job postings from the SourceStack API and posts them to the designated Slack channel. To initiate this process, run the bot and it will start posting random job openings.

### Setting Frequency

You can specify the posting frequency of job openings. Here the frequency is 1 hour. 
var schedule = new System.Threading.Timer(_ => PostRandomJobOpening(), null, TimeSpan.Zero, TimeSpan.FromHours(1));


###Contributing
Contributions to the Job Posting Slack Bot are welcome! If you encounter any issues or have suggestions for improvements, please submit a pull request or open an issue on the GitHub repository.

## Acknowledgements

We would like to express our gratitude to SourceStack for providing the job posting data through their API, and to OpenAI for their powerful GPT technology that enhances the bot's capabilities.

Enjoy using the Job Posting Slack Bot and simplify the process of sharing job openings with your team!
