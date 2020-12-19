<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <link rel="shortcut icon" href="../favicon.ico" type="image/x-icon">
    <!-- <title>Server Status</title> -->
  </head>
  <body class="bg-dark">
    <h1 class="text-white">Server Status</h1>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
    <table class="table table-bordered table-striped table-dark container-xl-8">
        <thead>
            <tr>
                <th scope="row">Status</th>
<?php
//Get the status and decode the JSON
$ip = 'game.nicetong.net:25566';
$apimain = json_decode(file_get_contents('https://mcapi.xdefcon.com/server/'.$ip.'/full/json'));
$apideco = json_decode(file_get_contents(('https://api.mcsrvstat.us/2/'.$ip)));
print("<title>Server Status | ".$ip."</title>");

if ($apimain->serverStatus == "online") {
    print ('<td><span style="color: #2ecc71;">'.ucfirst(($apimain->serverStatus)).'</span></td>');
    print("</tr>");
    print("</thead>");
    print("<tbody>");
    print("<tr>");
    print('<th scope="col">Server Name</th>');
    print('<th scope="col">'.$apideco->motd->html[0].'</th>');
    print("</tr>");
    print("<tr>");
    print('<th scope="col">Version</th>');
    print('<td>'.$apimain->version.'</td>');
    print("</tr>");
    print("<tr>");
    print('<th scope="col">IP</th>');
    print('<td>'.$ip.'</td>');
    print("</tr>");
    print("<tr>");
    print('<th scope="col">Players</th>');
    print('<td><span class="badge badge-pill badge-primary">'.$apimain->players." / ".$apimain->maxplayers.'</span></td>');
    print("</tr>");
    print("<tr>");
    print('<th scope="col">Ping</th>');
    print('<td>'.$apimain->ping." ms".'</td>');
    print("</tr>");

    print("</tbody>");
}else {
    print ('<td><span style="color: #e74c3c;">'.ucfirst(($apimain->serverStatus)).'</span></td>');
    print("</tr>");
    print("</thead>");
};
    ?>
      </table>

  </body>
</html>
