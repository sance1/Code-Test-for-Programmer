<!-- <p align="center">
<img width="1024" alt="Screen Shot 2023-08-19 at 2 14 08 PM" src="https://github.com/sance1/Project7Aug2023/assets/92260329/08498ce4-cdc4-411a-b920-b8e2f7e24396">
</p>

 -->


<!-- Features -->
## 🧐 Features


- [Query](#-query)
<br><br>


## Query

Buat Query DB untuk mendapatkan Total Undue (belum jatuh tempo) dan Total Overdue (sudah jatuh tempo). Dengan kondisi tanggal hari ini adalah 25 Mar 23. Dalam 1 query saja.

SELECT 
    SUM(CASE WHEN DueDate > '2023-03-25' THEN JumlahTagihan ELSE 0 END) AS TotalUndue,
    SUM(CASE WHEN DueDate <= '2023-03-25' THEN JumlahTagihan ELSE 0 END) AS TotalOverdue
FROM Tagihan;


Buatlah dalam 1 query untuk mendapatkan duplicate data berdasarkan 1 field.

SELECT column_name, COUNT(column_name) AS count
FROM table_name
GROUP BY column_name
HAVING COUNT(column_name) > 1;

Contoh
SELECT email, COUNT(email) AS count
FROM employees
GROUP BY email
HAVING COUNT(email) > 1;


Buatlah dalam 1 query antara 2 table (misal TableA dan TableB), untuk menemukan data yang missing dari TableB, berdasarkan 1 field.

SELECT TableA.field_name
FROM TableA
LEFT JOIN TableB ON TableA.field_name = TableB.field_name
WHERE TableB.field_name IS NULL;

Contoh
SELECT employees.employee_id
FROM employees
LEFT JOIN attendance ON employees.employee_id = attendance.employee_id
WHERE attendance.employee_id IS NULL;




<h3 align="left">Connect with me:</h3>
<p align="left">
<a href="https://linkedin.com/in/https://www.linkedin.com/in/sance-aenul-yakin-8724421a8/" target="blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/linked-in-alt.svg" alt="https://www.linkedin.com/in/sance-aenul-yakin-8724421a8/" height="30" width="40" /></a>
<a href="https://fb.com/https://web.facebook.com/aditya.reynand.18" target="blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/facebook.svg" alt="https://web.facebook.com/aditya.reynand.18" height="30" width="40" /></a>
<a href="https://instagram.com/https://www.instagram.com/sance_channel/" target="blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/instagram.svg" alt="https://www.instagram.com/sance_channel/" height="30" width="40" /></a>
<a href="https://www.youtube.com/c/https://www.youtube.com/@sancechannel6308/featured" target="blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/youtube.svg" alt="https://www.youtube.com/@sancechannel6308/featured" height="30" width="40" /></a>
</p>


<h3 align="left">Languages and Tools:</h3>
<p align="left"> <a href="https://getbootstrap.com" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/bootstrap/bootstrap-plain-wordmark.svg" alt="bootstrap" width="40" height="40"/> </a> <a href="https://codeigniter.com" target="_blank" rel="noreferrer"> <img src="https://cdn.worldvectorlogo.com/logos/codeigniter.svg" alt="codeigniter" width="40" height="40"/> </a> <a href="https://www.w3schools.com/cs/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="40" height="40"/> </a> <a href="https://www.w3schools.com/css/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/css3/css3-original-wordmark.svg" alt="css3" width="40" height="40"/> </a> <a href="https://dotnet.microsoft.com/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original-wordmark.svg" alt="dotnet" width="40" height="40"/> </a> <a href="https://www.w3.org/html/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/html5/html5-original-wordmark.svg" alt="html5" width="40" height="40"/> </a> <a href="https://developer.mozilla.org/en-US/docs/Web/JavaScript" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/javascript/javascript-original.svg" alt="javascript" width="40" height="40"/> </a> <a href="https://www.microsoft.com/en-us/sql-server" target="_blank" rel="noreferrer"> <img src="https://www.svgrepo.com/show/303229/microsoft-sql-server-logo.svg" alt="mssql" width="40" height="40"/> </a> <a href="https://www.mysql.com/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/mysql/mysql-original-wordmark.svg" alt="mysql" width="40" height="40"/> </a> <a href="https://www.php.net" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/php/php-original.svg" alt="php" width="40" height="40"/> </a> <a href="https://developer.apple.com/swift/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/swift/swift-original.svg" alt="swift" width="40" height="40"/> </a> </p>

<!--
<p><img align="left" src="https://github-readme-stats.vercel.app/api/top-langs?username=sance1&show_icons=true&locale=en&layout=compact" alt="sance1" /></p>

<p>&nbsp;<img align="center" src="https://github-readme-stats.vercel.app/api?username=sance1&show_icons=true&locale=en" alt="sance1" /></p>
-->
<p><img align="center" src="https://github-readme-streak-stats.herokuapp.com/?user=sance1&" alt="sance1" /></p>


---
<p align="center">
  Developed with ❤️ in Indonesia 🇮🇩 by Sance aenul yakin
</p>
