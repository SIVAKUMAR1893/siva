/*
 CSS for the main interaction
*/
.accordion > input[type="checkbox"] {
  position: absolute;
  left: -100vw;
}

.accordion .content {
  overflow-y: hidden;
  height: 0;
  transition: height 0.3s ease;
}

.accordion > input[type="checkbox"]:checked ~ .content {
  height: auto;
  overflow: visible;
}

.accordion label {
  display: block;
}

/*
 Styling
*/
body {
  font: 16px/1.5em "Overpass", "Open Sans", Helvetica, sans-serif;

  content: "\f078";
}

/*
 Demo purposes only
*/
*,
*:before,
*:after {
  box-sizing: border-box;
}

body {
  padding: 40px;
}

a {
  color: #06c;
}

p {
  margin: 0 0 1em;
}

h1 {
  margin: 0 0 1.5em;
  font-weight: 600;
  font-size: 1.5em;
}

.accordion {
  max-width: 65em;
}

.accordion p:last-child {
  margin-bottom: 0;
}




accordion > input[type="checkbox"]:checked ~ .content {
  padding: 15px;
  border: 1px solid #e8e8e8;
  border-top: 0;
}

.accordion .handle {
  margin: 0;
  font-size: 1.125em;
  line-height: 1.2em;
}

.accordion label {
  color: #333;
  cursor: pointer;
  font-weight: normal;
  padding: 15px;
  background: #e8e8e8;
}

.accordion label:hover,
.accordion label:focus {
  background: #d8d8d8;
}

accordion .handle label:before {
  font-family: "fontawesome";
  content: "\f054";
  display: inline-block;
  margin-right: 10px;
  font-size: 0.58em;
  line-height: 1.556em;
  vertical-align: middle;
}

.accordion > input[type="checkbox"]:checked ~ .handle label:before {
  content: "\f078";
}

/*
 Demo purposes only
*/
*,
*:before,
*:after {
  box-sizing: border-box;
}
body {
  padding: 40px;
}

a {
  color: #06c;
}

p {
  margin: 0 0 1em;
}

h1 {
  margin: 0 0 1.5em;
  font-weight: 600;
  font-size: 1.5em;
}

.accordion {
  max-width: 65em;
}

.accordion p:last-child {
  margin-bottom: 0;
}