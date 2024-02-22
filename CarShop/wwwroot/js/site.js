//topbtn//

// kada se stranica učita, postaviti funkciju za praćenje skrola
window.onscroll = function () { scrollFunction() };

function scrollFunction() {
    // ako korisnik skrola više od 20 piksela, prikazati će se gumb
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        document.getElementById("topBtn").classList.add("show");
    } else {
        document.getElementById("topBtn").classList.remove("show");
    }
}

// kada se klikne na gumb, vraća se na vrh stranice
function topFunction() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}

// povezivanje funkcije sa klikom na gumb
document.getElementById("topBtn").addEventListener("click", topFunction);

//topbtn//

//poruka za details//

// Objekt koji mapira ime proizvoda s odgovarajućom porukom
const productMessages = {
    'Car tyres': 'Explore Our Wide Range of High-Quality Tires!\n\nDiscover the perfect match for your vehicle with our diverse selection of top-notch tire models. From all-season to performance tires, we\'ve got you covered. Enhance your driving experience and ensure safety on the road with our premium tire collection.\n\nShop now and enjoy a smooth ride with confidence!',
    'Brake system': 'Discover Unmatched Braking Power!\n\nUpgrade your vehicle\'s performance with our high-performance brake systems. Designed to deliver exceptional stopping power, our brake systems ensure enhanced safety and control. Whether you\'re on the track or the road, trust our brakes to provide superior performance.\n\nDrive with confidence, brake with precision!',
    'Engine': 'Unleash Your Vehicle\'s True Potential!\n\nRevitalize your ride with our powerful and reliable engines. Built to deliver impressive horsepower and torque, our engines will take your driving experience to new heights. Engineered with precision and tested for endurance, our engines offer unmatched performance and durability.\n\nUnleash the power within!',
    'Body': 'Enhance Your Vehicle\'s Appearance and Protection!\n\nUpgrade your vehicle\'s style and protection with our premium body parts. From sleek bumpers to stylish grilles, our body parts not only enhance your car\'s aesthetics but also provide added protection on the road. Transform your vehicle into a head-turner with our quality body parts.\n\nElevate your style!',
    'Damping': 'Experience Unparalleled Ride Comfort!\n\nSmooth out every bump and enjoy a comfortable ride with our high-performance damping solutions. Engineered for optimal suspension control, our dampers ensure excellent handling and stability. Whether you\'re on rough terrains or smooth highways, our dampers deliver a refined driving experience.\n\nEmbrace the road with confidence!',
    'Oils and fluids': 'Keep Your Vehicle Running Smoothly!\n\nEnsure peak performance and longevity for your vehicle with our premium oils and fluids. From engine oils to transmission fluids, our high-quality products keep your cars vital components properly lubricated and protected.Trust our oils and fluids for a trouble- free journey.\n\nKeep your engine purring!'
};

function showModal(productName) {
    // Prikazivanje kockice
    const modalContainer = document.getElementById("modalContainer");
    const productMessage = document.getElementById("productMessage");
    productMessage.textContent = productMessages[productName];
    modalContainer.style.display = "block";
}

function hideModal() {
    // Sakrivanje kockice
    const modalContainer = document.getElementById("modalContainer");
    modalContainer.style.display = "none";
}

//poruka za details//