const express = require('express');
const cors = require('cors');
const ytdl = require('ytdl-core');
const app = express();
app.use(cors());

app.listen(80, () => {
	console.log('Server Works !!! At port 4000');
});

app.get('/downloadmp3', (req, res) => {
	var url = req.query.url;
	var file = req.query.File_Name;
	console.log(file)
	res.header('Content-Disposition', 'attachment; filename='+file+'.mp3');
	ytdl(url, {
		format: 'mp3',
		filter: 'audioonly'
		
	}).pipe(res);
});

app.get('/downloadmp4', (req, res) => {
	var url = req.query.url;
	var file = req.query.File_Name;
	res.header('Content-Disposition', 'attachment; filename='+file+'.mp4');
	ytdl(url, {
		format: 'mp4',
		quality: 'highest'
	}).pipe(res);
});