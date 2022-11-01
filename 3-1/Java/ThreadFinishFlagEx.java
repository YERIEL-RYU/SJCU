import java.awt.*;
import java.awt.event.*;
import javax.swing.*;


public class ThreadFinishFlagEx extends JFrame{
    private RandomThread th;
    public ThreadFinishFlagEx() {
        setTitle("ThreadFinishFlagEx 예제");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        Container c = getContentPane();
        c.setLayout(null);

        c.addMouseListener(new MouseAdapter(){
            @Override
            public void mousePressed(MouseEvent e) {
                th.finish();
            }
        });
    }

    public static void main(String[] args) {
        new ThreadFinishFlagEx();
    }
}
