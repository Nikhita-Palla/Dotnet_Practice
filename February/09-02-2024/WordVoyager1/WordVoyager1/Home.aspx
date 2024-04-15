<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WordVoyager1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div id="carouselExampleCaptions" class="carousel slide " >
        <div class="carousel-indicators">
          <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
          <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="1" aria-label="Slide 2"></button>
          <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="2" aria-label="Slide 3"></button>
        </div>
        <div class="carousel-inner" >
          <div class="carousel-item active" style="height: 500px;">
            <img src="https://res.cloudinary.com/teepublic/image/private/s--vtDBtkOY--/t_Preview/b_rgb:191919,c_lpad,f_jpg,h_630,q_90,w_1200/v1448636198/production/designs/12365_1.jpg" class="d-block w-100" alt="...">
            <div class="carousel-caption d-none d-md-block">
              <h5>Science</h5>
              <p>Science uncovers mysteries</p>
            </div>
          </div>
          <div class="carousel-item" style="height: 500px;">
            <img src="https://assets.entrepreneur.com/content/3x2/2000/20160105180846-brain-psychological-psychology-thinking-network-smart-education-creative-pointing.jpeg" class="d-block w-100" alt="...">
            <div class="carousel-caption d-none d-md-block">
              <h5>Psychology</h5>
              <p>Psychology delves into the depths of the human mind.</p>
            </div>
          </div>
          <div class="carousel-item" style="height: 500px;">
            <img src="https://wallpapercave.com/wp/wp5426550.jpg" class="d-block w-100" alt="...">
            <div class="carousel-caption d-none d-md-block">
              <h5>Technology</h5>
              <p>Technology revolutionizes our world</p>
            </div>
          </div>
        </div>
        <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="prev">
          <span class="carousel-control-prev-icon" aria-hidden="true"></span>
          <span class="visually-hidden">Previous</span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="next">
          <span class="carousel-control-next-icon" aria-hidden="true"></span>
          <span class="visually-hidden">Next</span>
        </button>
      </div>

    <div class="container">
        <div class="heading">
            <h2 style="text-align: center; font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;">Articles</h2>
        </div>
        <div class="row" style="margin: 20px;">
            <div class="col-4">
                <a href="articleView.aspx" class="card" id="cards">
                    <img src="https://insidebigdata.com/wp-content/uploads/2019/04/DataScience_shutterstock_1054542323.jpg" class="card-img-top" alt="..." width="200" height="200">
                    <div class="card-body">
                        <h5 class="card-title">Data Science</h5>
                        
                        <p class="card-text">Data science is an interdisciplinary field that utilizes scientific methods, algorithms, processes, and systems for traditional purposes.</p>
                    </div>
                    
                </a>
            </div>
    
            <div class="col-4">
                <a href="articleView.aspx" class="card" id="cards">
                    <img src="https://www.atulhost.com/wp-content/uploads/2017/06/big-data.jpg" class="card-img-top" alt="..." width="200" height="200">
                    <div class="card-body">
                        <h5 class="card-title">Big data</h5>
                        <p class="card-text">Big data refers to extremely large and complex datasets that cannot be easily managed, processed, or analyzed.</p>
                    </div>
                </a>
            </div>
    
            <div class="col-4">
                <a href="articleView.aspx" class="card" id="cards">
                    <img src="https://www.pixelstalk.net/wp-content/uploads/2016/10/Biology-Wallpaper-Full-HD.jpg" class="card-img-top" alt="..." width="200" height="200">
                    <div class="card-body">
                        <h5 class="card-title">DNA Science</h5>
                        <p class="card-text">DNA science, also known as genetics or molecular biology, is the study of deoxyribonucleic acid (DNA).</p>
                    </div>
                </a>
            </div>
        </div>
    
        <div class="row" style="margin: 20px;">
            <div class="col-4">
                <a href="articleView.aspx" class="card" id="cards">
                    <img src="https://th.bing.com/th/id/OIP.ERhRaeJrE8OUjla3KevOLgHaEO?rs=1&pid=ImgDetMain" class="card-img-top" alt="..." width="200" height="200">
                    <div class="card-body">
                        <h5 class="card-title">Hadoop</h5>
                        <p class="card-text">Hadoop is widely used for big data processing and analysis tasks and has become a used technology in the field of data analytics.</p>
                    </div>
                </a>
            </div>
    
            <div class="col-4">
                <a href="articleView.aspx" class="card" id="cards">
                    <img src="https://th.bing.com/th/id/R.9dae8065bc5edfd085ba0334dba39bfb?rik=yVksZ3uhCqo36w&riu=http%3a%2f%2fdesigngeekz.com%2fwp-content%2fuploads%2f2018%2f09%2fdotnet.jpg&ehk=8k%2bjUe3e9nBKWCwFNcXNcaiPvGohKqdZXow%2bTzlQ%2bnA%3d&risl=&pid=ImgRaw&r=0" class="card-img-top" alt="..." width="200" height="200">
                    <div class="card-body">
                        <h5 class="card-title">Dot Net</h5>
                        <p class="card-text">.NET, commonly referred to as dotNET, is a free, open-source developer platform created by Microsoft.</p>
                    </div>
                </a>
            </div>
    
            <div class="col-4">
                <a href="articleView.aspx" class="card" id="cards">
                    <img src="https://www.verywellmind.com/thmb/fF8hhE1vdAJNXHLfDqj6T700yMM=/1500x1000/filters:fill(ABEAC3,1)/The-Major-Branches-of-Psychology-4139786-final-15133a69be64406db16dc63cd97a3a17.png" class="card-img-top" alt="..." width="200" height="200">
                    <div class="card-body">
                        <h5 class="card-title">Fields of Psychology</h5>
                        <p class="card-text">Psychology is a broad field that encompasses various subfields, each focusing on different aspects of human behavior.</p>
                    </div>
                </a>
            </div>
        </div>
    </div>


</asp:Content>
