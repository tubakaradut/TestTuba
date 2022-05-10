class Kitap {
    constructor(id, kitapadi, yazar, fiyat) {
        this.id = id;
        this.KitapAdi = kitapadi;
        this.YazarAdi = yazar;
        this.Fiyat = fiyat
    }
}

class WebUI {

    static GetirKitap() {
        const KitapDizisi = [
            {
                id :1,
                KitapAdi: "Hayvan Çiftliği",
                YazarAdi:"George Orwell",
                Fiyat:35
            },
            {
                id : 2,
                KitapAdi : "Şeker Portakal",
                YazarAdi:"J.M. Vasconcelos",
                Fiyat:45
            },
            {
                id :3,
                KitapAdi : "İnsan Geleceğini Nasıl Kurar?",
                YazarAdi:"İlber Ortaylı",
                Fiyat:65
            }
        ]
        for (var i = 0; i < KitapDizisi.length; i++) {
            WebUI.Ekle(KitapDizisi[i])
        }
        //console.log(KitapDizisi);
    }
    static Ekle(kitap) {
        const kitaptablo = document.getElementById("kitaptable")
        const tr = document.createElement("tr");

        tr.innerHTML = `
                <td>${kitap.id}</td>
                <td>${kitap.KitapAdi}</td>
                <td>${kitap.YazarAdi}</td>
                <td>${kitap.Fiyat}</td>
`
        kitaptablo.appendChild(tr);

        console.log(tr);
        
    }
}
window.onload = function () {
    WebUI.GetirKitap();

    document.getElementById("buton").onclick = function () {
        const kitapadı = document.getElementById("kitapadi").value;
        const yazaradı = document.getElementById("yazaradi").value;
        const fiyat = document.getElementById("fiyat").value;

        const kitap1 = new Kitap(5, kitapadı, yazaradı, fiyat);
        //console.log(kitap1);
        WebUI.Ekle(kitap1);
    }

}

