import java.awt.*;
import javax.swing.*;

public class ListEx {
    private String [] fruits = {
        "apple", "banna", "kiwi", "mango", "pear", "peach", "berry", "strawberry", "blackberry"
    };
    private ImageIcon [] images = {
        new ImageIcon("images/icon1.png"),
        new ImageIcon("images/icon2.png"),
        new ImageIcon("images/icon3.png"),
        new ImageIcon("images/icon4.png")
    };

    public ListEx() {
        JList<String> strList = new JList<String>(fruits);
        c.add(strList);

        JList<ImageIcon> imageList = new JList<ImageIcon>();
        imageList.setListData(images);
        c.add(imageList);

        JList<String> scrollList = new JList<String>(fruits);
        c.add(new JScrollPane(scrollList));
    }

    public static void main(String[] args) {
        new ListEx();
    }
}
