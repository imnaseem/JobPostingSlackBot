﻿using System;
    //Below is channel ID
    private static readonly string channelId = "";
    //OpenAI ChatGPT API token
    private const string ChatGptApiToken = "";
    //Source Stack Api Url
    private static readonly string SourceStackApiUrl = "";
            // Schedule the job to run every hour
            var schedule = new System.Threading.Timer(_ => PostRandomJobOpening(), null, TimeSpan.Zero, TimeSpan.FromHours(1));

            // Stop the timer when done
            schedule.Dispose();
            // Fetch job opening data from SourceStack's API
            var jobData = await FetchJobOpeningsFromSourceStack();
                // Select a random job opening
                var random = new Random();
                
                // Compose the Slack message with the job opening details
                var message = "";

                }

                    var jn = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(randomJob["tags_matched"].ToString());

                    if (jn.Count > 0)

                    if (jn.Count > 0)


                if (randomJob["last_indexed"] != null)


                var coverMessage = " Please create cover letter for bellow job posting \n ";
                if (randomJob["job_name"].ToString() != null && randomJob["job_name"].ToString() != "")


                if (randomJob["tags_matched"].HasValues)

                //Below line of code posting job opening to slack
                await PostMessageToSlack(message);

        // Make an HTTP GET request to SourceStack's API and deserialize the response
        var response = await httpClient.GetAsync(SourceStackApiUrl);
        // Create the request body with the necessary parameters
        var requestBody = new StringContent($"token={slackApiToken}&channel={channelId}&text={message}", Encoding.UTF8, "application/x-www-form-urlencoded");

        // Make a POST request to the Slack API to post the message
        var response = await httpClient.PostAsync(slackApiUrl, requestBody);
        // Check the response body or status code if needed
    }