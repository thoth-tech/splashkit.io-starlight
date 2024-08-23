const express = require('express');
const axios = require('axios');
const cheerio = require('cheerio');

const app = express();

app.get('/download', async (req, res) => {
  const url = req.query.url;
  if (!url) {
    return res.status(400).send('Missing url parameter');
  }

  try {
    // Make the initial request to the API
    const apiResponse = await axios.get(`https://download-directory.github.io/?url=${encodeURIComponent(url)}`);
    const apiHtml = apiResponse.data;

    // Parse the HTML to find the download link
    const $ = cheerio.load(apiHtml);
    const downloadLink = $('a[download]').attr('href');

    if (!downloadLink) {
      return res.status(404).send('Download link not found');
    }

    // Fetch the download data
    const downloadResponse = await axios.get(downloadLink, { responseType: 'stream' });
    const downloadData = downloadResponse.data;

    // Set headers to trigger client-side download
    res.setHeader('Content-Type', 'application/octet-stream');
    res.setHeader('Content-Disposition', 'attachment; filename=data.zip');

    downloadData.pipe(res);
  } catch (error) {
    console.error(error);
    res.status(500).send('Error fetching data');
  }
});

app.listen(3000, () => {
  console.log('Server is running on port 3000');
});