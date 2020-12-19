var mp3Btn = document.getElementById('mp3');
var	mp4Btn = document.getElementById('mp4');
var	Filename = document.getElementById('Filename');
var URLinput = document.querySelector('.URL-input');
var server = 'http://localhost:4000';

mp3Btn.addEventListener('click', () => {
	if (URLinput.value != "") {
		var sentfn = Filename.value
		redirectMp3(URLinput.value,sentfn);
	}else{
		alert("ยังไม่ได้ใส่ URL")
		var x = SeBox.value
		alert(x)
	}
});


mp4Btn.addEventListener('click', () => {
	if (URLinput.value != "") {
		var sentfn = Filename.value
		redirectMp4(URLinput.value,sentfn);
	}else{
		alert("ยังไม่ได้ใส่ URL")
	}
});

function redirectMp3(query,fn,type) {
	window.location.href = `${server}/downloadmp3?url=${query}&File_Name=${fn}`;
}

function redirectMp4(query,fn,type) {
	window.location.href = `${server}/downloadmp4?url=${query}&File_Name=${fn}`;
}