function downloadFileAs(fileName, data) {
    var link = document.createElement('a');
    link.download = fileName;
    link.href = "data:application/octet-stream;base64," + data;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}
