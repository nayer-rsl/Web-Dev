//import required modules
const express = require("express");
const path = require("path");

//set up express object
const app = express();
const port = process.env.PORT || "8888";

//set up path
app.set("views", path.join(__dirname, "views"));
app.set("view engine", "pug");
app.use(express.static(path.join(__dirname,"public")));
//test express
//a get on the root is a page load
/*app.get("/" , (req, res) =>{
  res.status(200).send("testing...");
});*/

//set up some page routes
app.get("/", (req, res) => {
  res.render("index", { title: "Home" });
});
app.get("/Rings", (req, res) => {
  res.render("Rings", { title: "Rings" });
});
app.get("/Necklaces", (req, res) => {
  res.render("Necklaces", { title: "Necklaces" });
});
app.get("/Bracelets", (req, res) => {
  res.render("Bracelets", { title: "Bracelets" });
});
app.get("/Earrings", (req, res) => {
  res.render("Earrings", { title: "Earrings" });
});

//set up server listening
app.listen(port, () =>{
console.log(`listening on http://localhost:${port}`);
});